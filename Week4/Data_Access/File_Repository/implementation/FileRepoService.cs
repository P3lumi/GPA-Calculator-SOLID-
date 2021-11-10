using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Week4.Data_Access.File_Repository.interfaces;
using Week4.Model;

namespace Week4.Data_Access.File_Repository.implementation
{
    class FileRepoService : IFileRepo
    {
       
        private const string path = @"C:\Users\hp\Documents\Repo";
        private const string txtPath = @"C:\Users\hp\Documents\Repo\results.txt";
        DirectoryInfo saveDir;
        FileInfo file;

        public FileRepoService()
        {
            saveDir = new DirectoryInfo(path);
            if (!saveDir.Exists)
                saveDir.Create();
        }
        public Task Add(Course _course)
        {
            file = new FileInfo(txtPath);
            using (StreamWriter writer = new StreamWriter(file.Open(FileMode.Append, FileAccess.Write)))
            {
                writer.WriteLine($"\n| {_course.CourseCode} | {_course.CourseUnit} | {_course.CourseGrade} | {_course.GradeUnit} |"); 
                
                //writer.WriteLine($"\nYour Gpa = {data.Gpa:0.00}\n\n\n");
                writer.Close();
            }
            return Task.CompletedTask;

        }

        public void Read()
        {
            throw new NotImplementedException();
        }
    }
}





