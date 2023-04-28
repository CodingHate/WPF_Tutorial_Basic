using System.Collections.Generic;

namespace WPFTutorial
{
    public class Student
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Birthday { get; set; }
        public string School { get; set; }

        // 생성자 추가
        public Student(string name, string gender, string birthday, string school)
        {
            Name = name;
            Gender = gender;
            Birthday = birthday;
            School = school;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Gender: {Gender}, Birthday: {Birthday}, School: {School}";
        }

        public static List<Student> Students => new()
        {
            // 생성자를 이용하여 객체를 생성
            new Student("이름1", "남", "1", "1"),
            new Student("이름2", "여", "2", "2"),
            new Student("이름3", "남", "3", "3"),
            new Student("이름4", "여", "4", "4"),
        };
    }


}
