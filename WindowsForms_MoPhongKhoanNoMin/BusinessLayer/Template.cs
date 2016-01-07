using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_MoPhongKhoanNoMin.BusinessLayer
{
    public class Template
    {
        private String iD;
        private String tenTemplate;
        private String duongDan;
        private String moTa;
        private String anhMau;

        public String ID { get { return iD; } set { iD = value; } }
        public String TenTemplate { get { return tenTemplate; } set { tenTemplate = value; } }
        public String DuongDan { get { return duongDan; } set { duongDan = value; } }
        public String MoTa { get { return moTa; } set { moTa = value; } }
        public String AnhMau { get { return anhMau; } set { anhMau = value; } }

        public Template()
        {
            this.iD = null;
            this.tenTemplate = null;
            this.duongDan = null;
            this.moTa = null;
            this.anhMau = null;
        }

        public Template(String _id, String _tenTemplate, String _duongDan, String _moTa, String _anhMau)
        {
            this.iD = _id;
            this.tenTemplate = _tenTemplate;
            this.duongDan = _duongDan;
            this.moTa = _moTa;
            this.anhMau = _anhMau;
        }  
    }
}
