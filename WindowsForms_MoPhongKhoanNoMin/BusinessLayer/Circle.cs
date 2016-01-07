using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_MoPhongKhoanNoMin.BusinessLayer
{
    class Circle
    {
        private int handle;
        private double x;               //tọa độ X tâm đường tròn
        private double y;               //tọa độ Y tâm đường tròn
        private double radius;          //bán kính
        private Circle circleParent;    //đường tròn cha
        private List<Circle> circleChildrens; //các đường tròn con trong 1 đường tròn cha

        public Circle(int _handle)
        {
            this.handle = _handle;
            this.x = Lcad.PropGetFloat(handle, Lcad.LC_PROP_CIRCLE_X);
            this.y = Lcad.PropGetFloat(handle, Lcad.LC_PROP_CIRCLE_Y);
            this.radius = Lcad.PropGetFloat(handle, Lcad.LC_PROP_CIRCLE_RAD);
            this.circleChildrens = new List<Circle>();
            this.circleParent = null;
        }

        //set Circle Parent
        public void SetCircleParent(Circle _circlePrent)
        {
            this.circleParent = _circlePrent;
        }

        //add Circle Children
        public void AddCirleChildren(Circle _circleChidren)
        {
            circleChildrens.Add(_circleChidren);
        }

        //delete Circle Children
        public void RemoveCircleChildren(Circle _circleChildren)
        {
            circleChildrens.Remove(_circleChildren);
        }

        public bool HasParent()
        {
            if (this.circleParent != null)
                return true;
            return false;
        }

        //get giá trị của thuộc tính
        public int GetHandle()
        {
            return this.handle;
        }
        public double GetX()
        {
            return this.x;
        }
        public double GetY()
        {
            return this.y;
        }
        public double GetRadius()
        {
            return this.radius;
        }
        public int GetID()
        {
            return Lcad.PropGetInt(handle, Lcad.LC_PROP_ENT_ID);
        }

        //set giá trị của thuộc tính
        public void SetX(double _value)
        {
            this.x = _value;
        }
        public void SetY(double _value)
        {
            this.y = _value;
        }
        public void SetRadius(double _value)
        {
            this.radius = _value;
        }

        /*public string getID()
        {
            string id = Lcad.PropGetStr(handle,Lcad.LC_PROP_ENT_ID).ToString();
            return id;
        }*/
    }
}
