using testLib;

namespace edgeObject{
    class Edge{
        private double xCoordinate;
        private double yCoordinate;

        public Edge(){
            this.xCoordinate = 0;
            this.yCoordinate = 0;
        }

        public Edge(double xValue, double yValue){
            this.xCoordinate = xValue;
            this.yCoordinate = yValue;
        } 


        public double XCoordinate{
            set{xCoordinate = value;}
            get{return xCoordinate;}
        }

        public double YCoordinate{
            get{return yCoordinate;}
            set{yCoordinate = value;}
        }

        public static double distantFromOrigin (Edge a){
            return Math.Sqrt(Math.Pow(a.XCoordinate, 2) + Math.Pow(a.YCoordinate, 2));
        }
    }
}



