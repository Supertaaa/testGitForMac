using System;
using testLib;
using OpenCvSharp;


namespace std
{
    class Program
    {
        public static void Main(string[] args){
            Mat img = new Mat("/Users/apple/Downloads/BackGround/meinthepast.jpg");
            Cv2.ImShow("Me", img);
            Cv2.WaitKey(0);

        }

    }
}