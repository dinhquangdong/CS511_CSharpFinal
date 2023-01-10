using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final.DTO
{
    public class Account
    {
        public Account(int Id, string UserName, string DisplayName, string Password, int Type, string Gender, 
            float A00, float A01, float A02, float B00, float B01, float B02, float C00, float C01,
            float C02, float C03, float D01, float D07, float H00, float T00, float T03, float T04, float T05, float T06)
        {
            this.Id = Id;
            this.UserName = UserName;
            this.DisplayName = DisplayName;
            this.Password = Password;
            this.Type = Type;
            this.Gender = Gender;
            this.A00= A00; 
            this.A01 = A01;
            this.A02 = A02;
            this.B00= B00; 
            this.B01 = B01;
            this.B02 = B02;
            this.C00= C00; 
            this.C01 = C01;
            this.C02 = C02;
            this.C03 = C03;
            this.D01 = D01;
            this.D07 = D07;
            this.H00 = H00;
            this.T00 = T00;
            this.T03 = T03;
            this.T04 = T04;
            this.T05 = T05;
            this.T06 = T06;
        }
        
        public Account(DataRow row)
        {
            this.Id = (int)row["ID"];
            this.UserName = row["UserName"].ToString();
            this.DisplayName = row["DisplayName"].ToString();
            this.Password = row["Password"].ToString();
            this.Type = (int)row["Type"];
            this.Gender = row["Gender"].ToString();
            this.A00 = (float)Convert.ToDouble(row["A00"].ToString());
            this.A01 = (float)Convert.ToDouble(row["A01"].ToString());
            this.A02 = (float)Convert.ToDouble(row["A02"].ToString());
            this.B00 = (float)Convert.ToDouble(row["B00"].ToString());
            this.B01 = (float)Convert.ToDouble(row["B01"].ToString());
            this.B02 = (float)Convert.ToDouble(row["B02"].ToString());
            this.C00 = (float)Convert.ToDouble(row["C00"].ToString());
            this.C01 = (float)Convert.ToDouble(row["C01"].ToString());
            this.C02 = (float)Convert.ToDouble(row["C02"].ToString());
            this.C03 = (float)Convert.ToDouble(row["C03"].ToString());
            this.D01 = (float)Convert.ToDouble(row["D01"].ToString());
            this.D07 = (float)Convert.ToDouble(row["D07"].ToString());
            this.H00 = (float)Convert.ToDouble(row["H00"].ToString());
            this.T00 = (float)Convert.ToDouble(row["T00"].ToString());
            this.T03 = (float)Convert.ToDouble(row["T03"].ToString());
            this.T04 = (float)Convert.ToDouble(row["T04"].ToString());
            this.T05 = (float)Convert.ToDouble(row["T05"].ToString());
            this.T06 = (float)Convert.ToDouble(row["T06"].ToString());
        }

        private string _UserName, _DisplayName, _Password, _Gender;
        private int _Id, _Type;
        private float _A00, _A01, _A02, _B00, _B01, _B02, _C00, _C01, _C02, _C03, _D01, _D07, _H00, _T00, _T03, _T04, _T05, _T06;

        public string UserName { get => _UserName; set => _UserName = value; }
        public string DisplayName { get => _DisplayName; set => _DisplayName = value; }
        public string Password { get => _Password; set => _Password = value; }
        public string Gender { get => _Gender; set => _Gender = value; }
        public int Id { get => _Id; set => _Id = value; }
        public int Type { get => _Type; set => _Type = value;  }
        public float A00 { get => _A00; set => _A00 = value; }
        public float A01 { get => _A01; set => _A01 = value; }
        public float A02 { get => _A02; set => _A02 = value; }
        public float B00 { get => _B00; set => _B00 = value; }
        public float B01 { get => _B01; set => _B01 = value; }
        public float B02 { get => _B02; set => _B02 = value;  }
        public float C00 { get => _C00; set => _C00 = value; }
        public float C01 { get => _C01; set => _C01 = value; }
        public float C02 { get => _C02; set => _C02 = value; }
        public float C03 { get => _C03; set => _C03 = value; }
        public float D01 { get => _D01; set => _D01 = value; }
        public float D07 { get => _D07; set => _D07 = value; }
        public float H00 { get => _H00; set => _H00 = value; }
        public float T00 { get => _T00; set => _T00 = value; }
        public float T03 { get => _T03; set => _T03 = value; }
        public float T04 { get => _T04; set => _T04 = value; }
        public float T05 { get => _T05; set => _T05 = value; }
        public float T06 { get => _T06; set => _T06 = value; }
    }
}
