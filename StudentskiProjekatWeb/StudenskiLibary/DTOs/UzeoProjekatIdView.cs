using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiLibary.DTOs
{
    public class UzeoProjekatIdView
    {
        public StudentView Studentuzeo { get; set; }
        public ProjekatView uzeoProjekat { get; set; }

        public UzeoProjekatIdView(StudentView s, ProjekatView p)
        {
            Studentuzeo = s;
            uzeoProjekat = p;
        }

        public UzeoProjekatIdView()
        {
        }
    }
}
