#include <opencv2/opencv.hpp>  
using namespace std;

#pragma comment(linker, "/subsystem:\"windows\" /entry:\"mainCRTStartup\"")

int main()
{
   const char *pstrImageName = "21.png";
   const char *pstrWindowsTitle = "OpenCV��һ������";

  //���ļ��ж�ȡͼ��  
    IplImage *pImage = cvLoadImage(pstrImageName, CV_LOAD_IMAGE_UNCHANGED);

  //��������  
  cvNamedWindow(pstrWindowsTitle, 1);
  //��ָ����������ʾͼ��  
   cvShowImage(pstrWindowsTitle, pImage);

  //�ȴ������¼�  
   cvWaitKey();

   cvDestroyWindow(pstrWindowsTitle);
   cvReleaseImage(&pImage);
   return 0;
}
