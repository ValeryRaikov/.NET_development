using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace SchoolApp
{
    public static class FileManager
    {
        private static readonly string DirectorFile = "directors.json";
        private static readonly string TeacherFile = "teachers.json";
        private static readonly string StudentFile = "students.json";

        private static void SaveToFile<T>(string filePath, List<T> data)
        {
            string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        private static List<T> LoadFromFile<T>(string filePath)
        {
            if (!File.Exists(filePath)) 
                return new List<T>();

            string json = File.ReadAllText(filePath);

            return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
        }

        public static void SaveDirectors(List<Director> directors)
        {
            SaveToFile(DirectorFile, directors);
        }

        public static List<Director> LoadDirectors()
        {
            return LoadFromFile<Director>(DirectorFile);
        }

        public static void SaveTeachers(List<Teacher> teachers)
        {
            SaveToFile(TeacherFile, teachers);
        }

        public static List<Teacher> LoadTeachers()
        {
            return LoadFromFile<Teacher>(TeacherFile);
        }

        public static void SaveStudents(List<Student> students)
        {
            SaveToFile(StudentFile, students);
        }

        public static List<Student> LoadStudents()
        {
            return LoadFromFile<Student>(StudentFile);
        }
    }
}
