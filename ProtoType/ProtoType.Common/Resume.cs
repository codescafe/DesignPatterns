using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType.Common
{
    public class Resume : ICloneable
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Age { get; set; }
        public WorkExperience Work { get; set; }

        public Resume(string name)
        {
            Name = name;
            Work = new WorkExperience();
        }

        private Resume(WorkExperience work)
        {
            Work = (WorkExperience)work.Clone();
        }

        public void SetPersonalInfo(string sex, string age)
        {
            Sex = sex;
            Age = age;
        }

        public void SetWorkExperience(string company, string workDate)
        {
            Work.Company = company;
            Work.WorkDate = workDate;
        }

        public void Display()
        {
            Console.WriteLine("{0} {1} {2}", Name, Sex, Age);
            Console.WriteLine("Work Experience: {0} {1}", Work.Company, Work.WorkDate);
        }

        public object Clone()
        {
            var resume = new Resume(Work);
            resume.Name = Name;
            resume.Sex = Sex;
            resume.Age = Age;
            return resume;
        }
    }
}
