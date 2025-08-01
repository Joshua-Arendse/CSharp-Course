﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace QuizAppV2
{
    internal class Question
    {
        public string QuestionText { get; set; } //Property
        public string[] Answers { get; set; }
        public int CorrectAnswerIndex { get; set; }

        public Question(string questionText, string[] answers, int correctAnswerIndex) // Constructor
        {
            QuestionText= questionText;
            Answers= answers;
            CorrectAnswerIndex= correctAnswerIndex;
        }
        public bool IsCorrectAnswer(int choice)
        {
            return CorrectAnswerIndex == choice;
        }

    }
}
