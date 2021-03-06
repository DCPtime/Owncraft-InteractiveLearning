﻿using InteractiveLearning.Core;

namespace InteractiveLearning.NetworkInteraction
{
    class Networker
    {

        #region Singleton
        // Singleton --------------------------
        private static Networker _instance;

        public static Networker GetInstance()
        {
            if(_instance == null)
                _instance = new Networker();
            return _instance;
        }

        //-------------------------------------
        #endregion


        public delegate void TaskListReadingCallback(Category root);

        private TaskListReadingCallback _readingCallback;

        private Networker()
        {
            
        }


        public void RequestDataFromServer(TaskListReadingCallback callback)
        {
            _readingCallback = callback;
            // TODO Retreiving task list from tutor's server

            // Placeholder
            Category rootCategory = new Category();
            rootCategory.Name = "ROOT";
            rootCategory.Description = "Root category should not be displayed to user";
            Category integralsSubCat = new Category();

            // Integrals demo
            integralsSubCat.Name = "Integrals";
            integralsSubCat.Description = "Various exercises related to integral equations";
            LearningTask taskInt1 = new LearningTask
            {
                Name = "Task 1",
                TaskText = "Do smth"
            };
            integralsSubCat.Add(taskInt1);
            LearningTask taskInt2 = new LearningTask
            {
                Name = "Task 2",
                TaskText = "Do smth"
            };
            integralsSubCat.Add(taskInt2);
            rootCategory.Add(integralsSubCat);

            // Quadratic equations demo
            Category qeqSubCat = new Category();
            qeqSubCat.Name = "Quadratic equations";
            qeqSubCat.Description = "Quadratic equations resolving";
            rootCategory.Add(qeqSubCat);

            // Derivatives demo
            Category derivativesSubCat = new Category();
            derivativesSubCat.Name = "Derivatives";
            derivativesSubCat.Description = "Some exercises about derivatives";
            rootCategory.Add(derivativesSubCat);

            _readingCallback(rootCategory);
        }
        
    }
}
