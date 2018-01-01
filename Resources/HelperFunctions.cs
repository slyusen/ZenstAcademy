using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace ZenstAcademy.Resources
{
    public class HelperFunctions
    {
        public string GenerateStudentNumber(int Id)
        {
            string StudentNumber = "";

            string schoolPrefix = "906";
            string studentPrefix = "03";


            return StudentNumber = schoolPrefix + studentPrefix + Id.ToString() + Get7Digits();
        }

        public string Get7Digits()
        {
            var bytes = new byte[4];
            var rng = RandomNumberGenerator.Create();
            rng.GetBytes(bytes);
            uint random = BitConverter.ToUInt32(bytes, 0) % 100000000;
            return String.Format("{0:D7}", random);
        }
    }
}
