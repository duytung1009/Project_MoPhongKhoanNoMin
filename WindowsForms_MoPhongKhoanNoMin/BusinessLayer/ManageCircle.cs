using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_MoPhongKhoanNoMin.BusinessLayer
{
    class ManageCircle
    {
        private List<Circle> listCircles;    //biến lưu trữ danh sách các đối tượng Circle
        private double deltaX;              //khoảng cách giữa 2 Circle trong một hàng
        private double deltaY;              //khoảng cách giữa 2 Circle trong một cột
        private int rowCount;            //số hàng Circle trong một bản thiết kế
        private int columnCount;         //số dòng Circle trong một bản thiết kế
        private double xMin;
        private double yMin;
        private double xMax;
        private double yMax;

        //hàm tạo ManageCircle
        public ManageCircle()
        {
            this.listCircles = new List<Circle>();
            this.deltaX = 0;
            this.deltaY = 0;
            this.rowCount = 0;
            this.columnCount = 0;
            this.xMin = 0;
            this.xMax = 0;
            this.yMin = 0;
            this.yMax = 0;
        }

        //lấy giá trị thuộc tính
        public double GetDeltaX() { return this.deltaX; }
        public double GetDeltaY() { return this.deltaY; }
        public double GetXMin() { return this.xMin; }
        public double GetXMax() { return this.xMax; }
        public double GetYMin() { return this.yMin; }
        public double GetYMax() { return this.yMax; }
        public int GetRowCount() { return this.rowCount; }
        public int GetColumnCount() { return this.columnCount; }
        public List<Circle> GetListCircles() { return this.listCircles; }

        //hàm trả về ID của 1 Circle
        public int GetKeyOfCircle()
        {
            if (listCircles != null)
            {
                return Lcad.PropGetInt(listCircles[0].GetHandle(), Lcad.LC_PROP_ENT_KEY);
            }
            else return -1;
        }

        //hàm gán ID của 1 Circle
        public void SetKeyOfCircle(int keyvalue)
        {
            //duyệt từng circle trong listCircle
            foreach (var circle in listCircles)
            {
                Lcad.PropPutInt(circle.GetHandle(), Lcad.LC_PROP_ENT_KEY, keyvalue);
            }
        }

        //function calculate Delta X
        private void CalDeltaX()
        {
            if (listCircles.Count > 0)
            {
                double x0 = listCircles[0].GetX();
                double y0 = listCircles[0].GetY();
                //tính delta X
                this.deltaX = 0;
                foreach (var item in this.listCircles)
                {
                    if (y0 == item.GetY() && x0 != item.GetX())
                    {
                        this.deltaX = Math.Abs(x0 - item.GetX());
                        break;
                    }
                }
            }
        }
        //function calculate Delta Y
        private void CalDeltaY()
        {
            if (listCircles.Count > 0)
            {
                double x0 = listCircles[0].GetX();
                double y0 = listCircles[0].GetY();
                //tính delta Y
                this.deltaY = 0;
                foreach (var item in this.listCircles)
                {
                    if (x0 == item.GetX() && y0 != item.GetY())
                    {
                        this.deltaY = Math.Abs(y0 - item.GetY());
                        break;
                    }
                }
            }
        }
        ////hàm tính toán số hàng Circle trong bản thiết kế
        //public void CalRowCount()
        //{
        //    if (listCircles.Count > 0)
        //    {
        //        double x0 = listCircles[0].GetX();
        //        double y0 = listCircles[0].GetY();

        //        this.rowCount = 0;
        //        //tính số hàng
        //        foreach (var circle in this.listCircles)
        //        {
        //            if (x0 == circle.GetX())
        //            {
        //                this.rowCount++;
        //            }
        //        }
        //    }
        //}
        ////hàm tính toán số cột Circle trong bản thiết kế
        //public void CalColumCount()
        //{
        //    if (listCircles.Count > 0)
        //    {
        //        double x0 = listCircles[0].GetX();
        //        double y0 = listCircles[0].GetY();
        //        this.columnCount = 0;
        //        //tính số cột
        //        foreach (var circle in this.listCircles)
        //        {
        //            if (y0 == circle.GetY())
        //            {
        //                this.columnCount++;
        //            }
        //        }
        //    }
        //}

        //hàm thêm Circle vào ListCircle
        public void AddListCircle(List<Circle> newList)
        {
            foreach (var item in newList)
            {
                this.listCircles.Add(item);  //thêm 1 item Circle vào danh sách Circle
            }
            //kiểm tra ListCircle nếu tồn tại thì gán cho giá trị của x, y
            if (this.listCircles.Count > 0)
            {
                this.xMax = listCircles[0].GetX();
                this.xMin = listCircles[0].GetX();
                this.yMax = listCircles[0].GetY();
                this.yMin = listCircles[0].GetY();
                foreach (var item in newList)
                {
                    //thay đổi giá trị xMax, xMin, yMax, yMin
                    if (item.GetX() > this.xMax)
                        this.xMax = item.GetX();
                    if (item.GetX() < this.xMin)
                        this.xMin = item.GetX();
                    if (item.GetY() > this.yMax)
                        this.yMax = item.GetY();
                    if (item.GetY() < this.yMin)
                        this.yMin = item.GetY();
                }               
            }
            //CalColumCount();
            //CalRowCount();
            CalDeltaX();
            CalDeltaY();
        }

        //hàm xóa Circle khỏi ListCircle
        public void RemoveListCircles(List<Circle> _listCircles)
        {
            //remove elements in list
            foreach (Circle circle in _listCircles)
            {
                this.listCircles.Remove(circle);
            }
            //recalculate properties
            if (this.listCircles.Count > 0)
            {
                this.xMax = this.listCircles[0].GetX();
                this.xMin = this.listCircles[0].GetX();
                this.yMax = this.listCircles[0].GetY();
                this.yMin = this.listCircles[0].GetY();
                foreach (var circle in this.listCircles)
                {
                    //thay đổi giá trị xMax, xMin, yMax, yMin
                    if (circle.GetX() > this.xMax)
                        this.xMax = circle.GetX();
                    if (circle.GetX() < this.xMin)
                        this.xMin = circle.GetX();
                    if (circle.GetY() > this.yMax)
                        this.yMax = circle.GetY();
                    if (circle.GetY() < this.yMin)
                        this.yMin = circle.GetY();
                }
                //CalColumCount();
                //CalRowCount();
                CalDeltaX();
                CalDeltaY();
            }
            else
            {
                this.xMax = 0;
                this.xMin = 0;
                this.yMax = 0;
                this.yMin = 0;
                this.rowCount = 0;
                this.columnCount = 0;
                this.deltaX = 0;
                this.deltaY = 0;
            }
        }

        //hàm trả về danh sách cột ở cuối bên phải
        public List<Circle> GetListCirleOfLastColumn()
        {
            List<Circle> list = new List<Circle>();
            foreach (Circle circle in this.listCircles)
            {
                if (circle.GetX() == this.xMax)
                {
                    list.Add(circle);
                }
            }
            return list;
        }

        //hàm trả về danh sách cột ở cuối bên trái
        public List<Circle> GetListCirleOfFirstColumn()
        {
            List<Circle> list = new List<Circle>();
            foreach (Circle circle in this.listCircles)
            {
                if (circle.GetX() == this.xMin)
                {
                    list.Add(circle);
                }
            }
            return list;
        }

        //hàm trả về danh sách hàng ở trên cùng
        public List<Circle> GetListCircleOfFirstRow()
        {
            List<Circle> newList = new List<Circle>();
            foreach (var circle in this.listCircles)
            {
                if (circle.GetY() == this.yMax)
                {
                    newList.Add(circle);
                }
            }
            return newList;
        }

        //hàm trả về danh sách hàng ở dưới cùng
        public List<Circle> GetListCircleOfLastRow()
        {
            List<Circle> newList = new List<Circle>();
            foreach (var circle in this.listCircles)
            {
                if (circle.GetY() == this.yMin)
                {
                    newList.Add(circle);
                }
            }
            return newList;
        }

        /// <summary>
        /// Hàm tìm kiếm Circle theo id
        /// </summary>
        /// <param name="_handle">ID của Circle cần tìm</param>
        /// <returns>Circle</returns>
        public Circle FindCircle(int _handle)
        {
            foreach (var circle in this.listCircles)
            {
                if (circle.GetHandle() == _handle)
                    return circle;
            }
            return null;
        }

        //giải pháp thay thế
        public void CalRowCount()
        {

        }
        public void CalColumCount()
        {

        }
        public void CalBaseAngle()
        {
            double x0 = listCircles[0].GetX();
            double x1 = listCircles[1].GetX();
        }
    }
}
