using Microsoft.EntityFrameworkCore;
using SchoolSubjectMatter.Data;

namespace SchoolSubjectMatter.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SchoolSubjectMatterContext(serviceProvider.GetRequiredService<DbContextOptions<SchoolSubjectMatterContext>>()))
            {
                if (context != null)
                {
                    return;
                }

                var sMath = new Subject 
                { 
                    Name = "Math" 
                };
                var sBiology = new Subject 
                { 
                    Name = "Biology" 
                };
                var sInformatics = new Subject 
                { 
                    Name = "Informatics" 
                };

                var t1 = new Teacher 
                { 
                    FirstName = "",
                    LastName = "",
                    Address = "",
                };
                var t2 = new Teacher
                {
                    FirstName = "",
                    LastName = "",
                    Address = "",
                };
                var t3 = new Teacher
                {
                    FirstName = "",
                    LastName = "",
                    Address = "",
                };

                t1.Subjects.Add(sMath);
                t2.Subjects.Add(sBiology);
                t3.Subjects.Add(sInformatics);
                t3.Subjects.Add(sMath);



                context.AddRange(
                    new Subject
                    {
                        Name = "Math",

                    }
                    );
            }
        }
    }
}
