﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    internal class RankedGradeBook:BaseGradeBook
    {
        public RankedGradeBook(string name):base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade)
        {
            if (CountStudents()<5)
            {
                throw new InvalidOperationException("ERROR");
            }
            else
            {
                if (averageGrade >= 80)
                    return 'A';
                else if (averageGrade >= 60)
                    return 'B';
                else if (averageGrade >= 40)
                    return 'C';
                else if (averageGrade >= 20)
                    return 'D';
                else
                    return 'F';
            }
        }
        public override void CalculateStudentStatistics(string name)
        {
            if (CountStudents()<5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else
            {
                base.CalculateStudentStatistics(name);
            }
        }
    }
}
