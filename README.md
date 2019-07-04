# ShapeAreaLibrary01
class Shape                                                       //Shape class
  double Area                                                     //Shape.Area
  double RecogniseAndGetArea(double r)                            //Calculates an area of a circle 
  double RecogniseAndGetArea(double a, double b, double c)        //Calculates an area of a triangle

class Circle : Shape                                              //Circle subclass
  public double Radius                                            //Circle.Radius
  public void CalculateArea(double radius)                        //Calculates Shape.Area af a triangle 
  
class Triangle : Shape                                            //Triangle class
  bool RightTriangle                                              //Triangle.RightTriangle Whether a triangle right
  double[] Side                                                   //Array of a triangle's 3 sides
  void CalculateArea(double a = 0, double b = 0, double c = 0)    //Calculates Triangle.Area
  void GetRight(double a = 0, double b = 0, double c = 0)         //Calculates Triangle.RightTriangle
