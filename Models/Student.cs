using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    //class - table
                
        public class Student
        {

        // Properties == columns
           public int ID { get; set; }
            [Required]
            [StringLength(50)]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }
            [Required]
            [StringLength(50)]
            [Column("FirstName")]
            [Display(Name = "First Name")]
            [RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "last name must be letter only start with upper letter.")]
            public string FirstMidName { get; set; }
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
            [Display(Name = "Enrollment Date")]
            public DateTime EnrollmentDate { get; set; }
            [Display(Name = "Full Name")]
            public string FullName
            {
                get
                {
                    return LastName + ", " + FirstMidName;
                }
            }

            //navegation Property
            public ICollection<Enrollment> Enrollments { get; set; }
        }
    }

