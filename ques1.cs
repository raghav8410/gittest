using System;

public class Shape
{	
  public Shape(double dimension1)
  {
    
  }
	
  public Shape(double dimension1,double dimension2)
  {
    
  }
	
  public virtual double Area()
  {
    return 0;
  }
}

public class Square : Shape
{
 double dimension1,area;
 public Square(double dimension1) :  base(dimension1)
  {
    this.dimension1=dimension1;
  }
  
  public override double Area()
  {
    area=dimension1*dimension1;
    return area;
  }
}

public class Rectangle : Shape
{
 double dimension1,dimension2,area;
 public Rectangle(double dimension1,double dimension2) :  base(dimension1,dimension2)
  {
    this.dimension1=dimension1;
	this.dimension2=dimension2;
  }
  
  public override double Area()
  {
    area=dimension1*dimension2;
    return area;
  }
}

public class Circle : Shape
{
 double dimension1,area;
 public Circle(double dimension1) :  base(dimension1)
  {
    this.dimension1=dimension1;
  }
  
  public override double Area()
  {
    area=3.14*dimension1*dimension1;
    return area;
  }
}

public class Ellipse : Shape
{
 double dimension1,dimension2,area;
 public Ellipse(double dimension1,double dimension2) :  base(dimension1,dimension2)
  {
     this.dimension1=dimension1;
	  this.dimension2=dimension2;
  }
  
  public override double Area()
  {
    area=3.14*dimension1*dimension2;
    return area;
  }
}

public class main
{
  public static void Main()
  {
	  int WantToContinue=0;
	  do
	  {
    int choice;
	  Console.WriteLine("Input the choice.\n1.Press 1 for Square\n2.Press 2 for Rectangle\n3.Press 3 for Circle\n4.Press 4 for Ellipse");
	  Int32.TryParse(Console.ReadLine(),out choice);
	  
	  switch(choice)
	  {
			  case 1: 
			  			double side;
			            Console.WriteLine("Enter the side");
			  			bool IsConversionSuccessSquare=Double.TryParse(Console.ReadLine(),out side);
			  			if(IsConversionSuccessSquare)
						{
							if(side>0)
							{
			            Shape square = new Square(side);
			  			Console.WriteLine("Area = {0}",square.Area());
							}
							else
								Console.WriteLine("Enter the positive number only");
						}
			  			else
							Console.WriteLine("Enter the numbers only");
			  			break;
			  
			  case 2: 
			  			double length,breadth;
			            Console.WriteLine("Enter the length");
			  			bool IsConversionSuccessRectangle=Double.TryParse(Console.ReadLine(),out length);
			  			if(IsConversionSuccessRectangle)
						{
							if(length>0)
							{
			  			Console.WriteLine("Enter the bredth");
			  			bool IsConversionSuccessRectangleBreadth=Double.TryParse(Console.ReadLine(),out breadth);
								if(IsConversionSuccessRectangleBreadth)
								{
									if(breadth>0)
									{
			  			Shape rectangle = new Rectangle(length,breadth);
			  			Console.WriteLine("Area = {0}",rectangle.Area());
									}
									else
									Console.WriteLine("Enter the positive numbers only");
								}
								else
								Console.WriteLine("Enter the numbers only");
							}
							else
							Console.WriteLine("Enter the positive numbers only");
						}
			  			else
						Console.WriteLine("Enter the numbers only");
			   			break;
			  
			  case 3: 
			  			double radius;
			            Console.WriteLine("Enter the radius");
			  			bool IsConversionSuccessCircle=Double.TryParse(Console.ReadLine(),out radius);
			  			if(IsConversionSuccessCircle)
						{
							if(radius>0)
							{
			  			Shape circle = new Circle(radius);
			  			Console.WriteLine("Area = {0}",circle.Area());
						    }
							else
							Console.WriteLine("Enter the positive numbers only");
						}
			  			else
						Console.WriteLine("Enter the numbers only");
			   			break;
			  
			  case 4: 
			  			double DistanceToVertex,DistanceToCoVertex;
			            Console.WriteLine("Enter the DistanceToVertex");
			  	        bool IsConversionSuccessEllipseDistanceToVertex=Double.TryParse(Console.ReadLine(),out DistanceToVertex);
			  			if(IsConversionSuccessEllipseDistanceToVertex)
						{
							if(DistanceToVertex>0)
							{
			  			Console.WriteLine("Enter the DistanceToCoVertex");
			  			bool IsConversionSuccessEllipseDistanceToCoVertex=Double.TryParse(Console.ReadLine(),out DistanceToCoVertex);
								if(IsConversionSuccessEllipseDistanceToCoVertex)
								{
									if(DistanceToCoVertex>0)
									{
			  			Shape ellipse = new Ellipse(DistanceToVertex,DistanceToCoVertex);
			  			Console.WriteLine("Area = {0}",ellipse.Area());
									}
									else
									Console.WriteLine("Enter the positive numbers only");
								}
								else
								Console.WriteLine("Enter the numbers only");
							}
							else
							Console.WriteLine("Enter the positive numbers only");
						}
			  			else
						Console.WriteLine("Enter the numbers only");
			   			break;
			  
			  default:  Console.WriteLine("You have made wrong choice.");
                        break;
			  
	  }
		      Console.WriteLine("Press 1 to continue");
			  Int32.TryParse(Console.ReadLine(),out WantToContinue);
	  }
		  while(WantToContinue==1);
  }
}


-------------------------------------------------------------------------------------------------------------------------------


using System;
					
public abstract class Shape
{
	public static double pie=3.14F;
	
	public Shape(double dimension1)
	{
	  
	}
	public Shape(double dimension1,double dimension2)
	{
	  
	}
    public abstract double Area();
}

public class Square : Shape
{

  private double side;

  public Square(double side) : base(side)
  {
    this.side=side;
  }
 
  public override double Area()
  {
    return pie*side*side;
  }
}

public class Rectangle : Shape
{

  private double length,breadth;

  public Rectangle(double length,double breadth) : base(length,breadth)
  {
    this.length=length;
	this.breadth=breadth;
  }

  public override double Area()
  {
    return length*breadth;
  }
}

public class Circle : Shape
{

  private double radius;

  public Circle(double radius) : base(radius)
  {
    this.radius=radius;
  }

  public override double Area()
  {
    return pie*radius*radius;
  }
}

public class Ellipse : Shape
{

  private double DistanceToVertex,DistanceToCoVertex;

  public Ellipse(double DistanceToVertex,double DistanceToCoVertex) : base(DistanceToVertex,DistanceToCoVertex)
  {
    this.DistanceToVertex=DistanceToVertex;
	this.DistanceToCoVertex=DistanceToCoVertex;
  }

  public override double Area()
  {
    return pie*DistanceToVertex*DistanceToCoVertex;
  }
}

public class main
{
  public static void Main()
  {
	  int WantToContinue=0;
	  do
	  {
    int choice;
	  Console.WriteLine("Input the choice.\n1.Press 1 for Square\n2.Press 2 for Rectangle\n3.Press 3 for Circle\n4.Press 4 for Ellipse");
	  Int32.TryParse(Console.ReadLine(),out choice);
	  
	  switch(choice)
	  {
			  case 1: 
			  			double side;
			            Console.WriteLine("Enter the side");
			  			bool IsConversionSuccessSquare=Double.TryParse(Console.ReadLine(),out side);
			  			if(IsConversionSuccessSquare)
						{
							if(side>0)
							{
			            Shape square = new Square(side);
			  			Console.WriteLine("Area = {0}",square.Area());
							}
							else
								Console.WriteLine("Enter the positive number only");
						}
			  			else
							Console.WriteLine("Enter the numbers only");
			  			break;
			  
			  case 2: 
			  			double length,breadth;
			            Console.WriteLine("Enter the length");
			  			bool IsConversionSuccessRectangle=Double.TryParse(Console.ReadLine(),out length);
			  			if(IsConversionSuccessRectangle)
						{
							if(length>0)
							{
			  			Console.WriteLine("Enter the bredth");
			  			bool IsConversionSuccessRectangleBreadth=Double.TryParse(Console.ReadLine(),out breadth);
								if(IsConversionSuccessRectangleBreadth)
								{
									if(breadth>0)
									{
			  			Shape rectangle = new Rectangle(length,breadth);
			  			Console.WriteLine("Area = {0}",rectangle.Area());
									}
									else
									Console.WriteLine("Enter the positive numbers only");
								}
								else
								Console.WriteLine("Enter the numbers only");
							}
							else
							Console.WriteLine("Enter the positive numbers only");
						}
			  			else
						Console.WriteLine("Enter the numbers only");
			   			break;
			  
			  case 3: 
			  			double radius;
			            Console.WriteLine("Enter the radius");
			  			bool IsConversionSuccessCircle=Double.TryParse(Console.ReadLine(),out radius);
			  			if(IsConversionSuccessCircle)
						{
							if(radius>0)
							{
			  			Shape circle = new Circle(radius);
			  			Console.WriteLine("Area = {0}",circle.Area());
						    }
							else
							Console.WriteLine("Enter the positive numbers only");
						}
			  			else
						Console.WriteLine("Enter the numbers only");
			   			break;
			  
			  case 4: 
			  			double DistanceToVertex,DistanceToCoVertex;
			            Console.WriteLine("Enter the DistanceToVertex");
			  	        bool IsConversionSuccessEllipseDistanceToVertex=Double.TryParse(Console.ReadLine(),out DistanceToVertex);
			  			if(IsConversionSuccessEllipseDistanceToVertex)
						{
							if(DistanceToVertex>0)
							{
			  			Console.WriteLine("Enter the DistanceToCoVertex");
			  			bool IsConversionSuccessEllipseDistanceToCoVertex=Double.TryParse(Console.ReadLine(),out DistanceToCoVertex);
								if(IsConversionSuccessEllipseDistanceToCoVertex)
								{
									if(DistanceToCoVertex>0)
									{
			  			Shape ellipse = new Ellipse(DistanceToVertex,DistanceToCoVertex);
			  			Console.WriteLine("Area = {0}",ellipse.Area());
									}
									else
									Console.WriteLine("Enter the positive numbers only");
								}
								else
								Console.WriteLine("Enter the numbers only");
							}
							else
							Console.WriteLine("Enter the positive numbers only");
						}
			  			else
						Console.WriteLine("Enter the numbers only");
			   			break;
			  
			  default:  Console.WriteLine("You have made wrong choice.");
                        break;
			  
	  }
		      Console.WriteLine("Press 1 to continue");
			  Int32.TryParse(Console.ReadLine(),out WantToContinue);
	  }
		  while(WantToContinue==1);
	      Console.WriteLine("Invalid Input Detected.\nProgram ends.");
  }
}

------------------------------------------------------------------------------------------------

through abstraction

using System;
					
public abstract class Shape
{
	public static double pie=3.14F;
	
	public Shape(double dimension1)
	{
	
	}
	
	public Shape(double dimension1,double dimension2)
	{
	
	}

    public abstract double Area();
	
	public abstract double Perimeter();
}

public class Square : Shape
{

 private double side;

 public Square(double side) : base(side)
 {
  this.side=side;
 }

 public override double Area()
 {
  return pie*side*side;
 }
 
 public override double Perimeter()
 {
  return 4*side;
 }
}

public class Rectangle : Shape
{

 private double length,breadth;
 
 public Rectangle(double length,double breadth) : base(length,breadth)
 {
  this.length=length;
  this.breadth=breadth;
 }

 public override double Area()
 {
  return length*breadth;
 }
 public override double Perimeter()
 {
  return 2*(length+breadth);
 }
}

public class Circle : Shape
{

 private double radius;
 
 public Circle(double radius) : base(radius)
 {
  this.radius=radius;
 }

 public override double Area()
 {
  return pie*radius*radius;
 }
 public override double Perimeter()
 {
  return 2*pie*radius;
 }
}

public class Ellipse : Shape
{

 private double DistanceToVertex,DistanceToCoVertex;
 
 public Ellipse(double DistanceToVertex,double DistanceToCoVertex) : base(DistanceToVertex,DistanceToCoVertex)
 {
  this.DistanceToVertex=DistanceToVertex;
  this.DistanceToCoVertex=DistanceToCoVertex;
 }
 
 public override double Area()
 {
  return pie*DistanceToVertex*DistanceToCoVertex;
 }
 public override double Perimeter()
 {
  return 2*pie*(Math.Sqrt(((DistanceToVertex*DistanceToVertex)+(DistanceToCoVertex*DistanceToCoVertex))/2));
 }
}

public class Calculation
{
	int WantToContinue=0;
  public void SquareCalculation()
  {
	do
	{
    int choice;
	Console.WriteLine("Input the choice.\n1.Press 1 for Area of Square\n2.Press 2 for Perimeter of Square");
	Int32.TryParse(Console.ReadLine(),out choice);
		
	switch(choice)
		
	{
			
	case 1:
		
	double side;
    Console.WriteLine("Enter the side");
	bool IsConversionSuccessSquareArea=Double.TryParse(Console.ReadLine(),out side);
	if(IsConversionSuccessSquareArea)
	{
	 if(side>0)
	   {
		Shape square = new Square(side);
		Console.WriteLine("Area = {0}",square.Area());
	   }
	else
	  Console.WriteLine("Enter the positive number greater then zero only");
	}
	else
	Console.WriteLine("Enter the numbers only");
			
	break;
			
    case 2 :  
			double PerimeterSide;
    Console.WriteLine("Enter the side");
	bool IsConversionSuccessSquarePerimeter=Double.TryParse(Console.ReadLine(),out PerimeterSide);
	if(IsConversionSuccessSquarePerimeter)
	{
	 if(PerimeterSide>0)
	   {
		Shape square = new Square(PerimeterSide);
		Console.WriteLine("Perimeter = {0}",square.Perimeter());
	   }
	else
	  Console.WriteLine("Enter the positive number greater then zero only");
	}
	else
	Console.WriteLine("Enter the numbers only");
			
	break;
	
    default: Console.WriteLine("You have made wrong choice");
			break;
	}
      Console.WriteLine("Press 1 to continue");
	  Int32.TryParse(Console.ReadLine(),out WantToContinue);
	  }
		  while(WantToContinue==1);
	      Console.WriteLine("You have made wrong choice.");  
}
	
  public void RectangleCalculation()
  {
	  
	do
	{
    int choice;
	Console.WriteLine("Input the choice.\n1.Press 1 for Area of Rectangle\n2.Press 2 for Perimeter of Rectangle");
	Int32.TryParse(Console.ReadLine(),out choice);
		
	switch(choice)
		
	{
			
	case 1:
    double length,breadth;
	Console.WriteLine("Enter the length");
	bool IsConversionSuccessRectangle=Double.TryParse(Console.ReadLine(),out length);
	if(IsConversionSuccessRectangle)
	{
	  if(length>0)
	  {
	  Console.WriteLine("Enter the bredth");
	  bool IsConversionSuccessRectangleBreadth=Double.TryParse(Console.ReadLine(),out breadth);
		if(IsConversionSuccessRectangleBreadth)
		{
	      if(breadth>0)
		  {
			Shape rectangle = new Rectangle(length,breadth);
			Console.WriteLine("Area = {0}",rectangle.Area());
		  }
		  else
		  Console.WriteLine("Enter the positive numbers greater then zero only");
		}
		else
		Console.WriteLine("Enter the numbers only");
      }
	  else
	  Console.WriteLine("Enter the positive numbers greater then zero only");
	 }
	 else
	 Console.WriteLine("Enter the numbers only");
			break;
			
		case 2:
			
			double PerimeterLength,PerimeterBreadth;
	Console.WriteLine("Enter the length");
	bool IsConversionSuccessRectanglePerimeter=Double.TryParse(Console.ReadLine(),out PerimeterLength);
	if(IsConversionSuccessRectanglePerimeter)
	{
	  if(PerimeterLength>0)
	  {
	  Console.WriteLine("Enter the bredth");
	  bool IsConversionSuccessRectangleBreadthPerimeter=Double.TryParse(Console.ReadLine(),out PerimeterBreadth);
		if(IsConversionSuccessRectangleBreadthPerimeter)
		{
	      if(PerimeterBreadth>0)
		  {
			Shape rectangle = new Rectangle(PerimeterLength,PerimeterBreadth);
			Console.WriteLine("Perimeter = {0}",rectangle.Perimeter());
		  }
		  else
		  Console.WriteLine("Enter the positive numbers greater then zero only");
		}
		else
		Console.WriteLine("Enter the numbers only");
      }
	  else
	  Console.WriteLine("Enter the positive numbers greater then zero only");
	 }
	 else
	 Console.WriteLine("Enter the numbers only");
			break;
			
		default:Console.WriteLine("You have made wrong choice");
			    break;
			
	}
  Console.WriteLine("Press 1 to continue");
			  Int32.TryParse(Console.ReadLine(),out WantToContinue);
	  }
		  while(WantToContinue==1);
	      Console.WriteLine("You have made wrong choice");
}
	
  public void CircleCalculation()
  {
	  do
	{
    int choice;
	Console.WriteLine("Input the choice.\n1.Press 1 for Area of Circle\n2.Press 2 for Perimeter of Circle");
	Int32.TryParse(Console.ReadLine(),out choice);
		
	switch(choice)
		
	{
			
	case 1:
    					double radius;
			            Console.WriteLine("Enter the radius");
			  			bool IsConversionSuccessCircle=Double.TryParse(Console.ReadLine(),out radius);
			  			if(IsConversionSuccessCircle)
						{
							if(radius>0)
							{
			  			Shape circle = new Circle(radius);
			  			Console.WriteLine("Area = {0}",circle.Area());
						    }
							else
							Console.WriteLine("Enter the positive numbers greater then zero only");
						}
			  			else
						Console.WriteLine("Enter the numbers only");
			break;
			
		case 2:
			            double PerimeterRadius;
			            Console.WriteLine("Enter the radius");
			  			bool IsConversionSuccessCirclePerimeter=Double.TryParse(Console.ReadLine(),out PerimeterRadius);
			  			if(IsConversionSuccessCirclePerimeter)
						{
							if(PerimeterRadius>0)
							{
			  			Shape circle = new Circle(PerimeterRadius);
			  			Console.WriteLine("Perimeter = {0}",circle.Perimeter());
						    }
							else
							Console.WriteLine("Enter the positive numbers greater then zero only");
						}
			  			else
						Console.WriteLine("Enter the numbers only");
			break;
			   
		default:Console.WriteLine("You have made wrong choice");
			    break;
			
	     }
     Console.WriteLine("Press 1 to continue");
			  Int32.TryParse(Console.ReadLine(),out WantToContinue);
	  }
		  while(WantToContinue==1);
	      Console.WriteLine("You have made wrong choice");
}
  
	
  public void EllipseCalculation()
  {
	  
	  do
	{
    int choice;
	Console.WriteLine("Input the choice.\n1.Press 1 for Area of Ellipse\n2.Press 2 for Perimeter of Ellipse");
	Int32.TryParse(Console.ReadLine(),out choice);
		
	switch(choice)
		
	{
			
	case 1:
   						double DistanceToVertex,DistanceToCoVertex;
			            Console.WriteLine("Enter the DistanceToVertex");
			  	        bool IsConversionSuccessEllipseDistanceToVertex=Double.TryParse(Console.ReadLine(),out DistanceToVertex);
			  			if(IsConversionSuccessEllipseDistanceToVertex)
						{
							if(DistanceToVertex>0)
							{
			  			Console.WriteLine("Enter the DistanceToCoVertex");
			  			bool IsConversionSuccessEllipseDistanceToCoVertex=Double.TryParse(Console.ReadLine(),out DistanceToCoVertex);
								if(IsConversionSuccessEllipseDistanceToCoVertex)
								{
									if(DistanceToCoVertex>0)
									{
			  			Shape ellipse = new Ellipse(DistanceToVertex,DistanceToCoVertex);
			  			Console.WriteLine("Area = {0}",ellipse.Area());
									}
									else
									Console.WriteLine("Enter the positive numbers greater then zero only");
								}
								else
								Console.WriteLine("Enter the numbers only");
							}
							else
							Console.WriteLine("Enter the positive numbers greater then zero only");
						}
			  			else
						Console.WriteLine("Enter the numbers only");
			break;
			
		case 2:
			double PerimeterDistanceToVertex,PerimeterDistanceToCoVertex;
			            Console.WriteLine("Enter the DistanceToVertex");
			  	        bool IsConversionSuccessEllipseDistanceToVertexPerimeter=Double.TryParse(Console.ReadLine(),out PerimeterDistanceToVertex);
			  			if(IsConversionSuccessEllipseDistanceToVertexPerimeter)
						{
							if(PerimeterDistanceToVertex>0)
							{
			  			Console.WriteLine("Enter the DistanceToCoVertex");
			  			bool IsConversionSuccessEllipseDistanceToCoVertexPerimeter=Double.TryParse(Console.ReadLine(),out PerimeterDistanceToCoVertex);
								if(IsConversionSuccessEllipseDistanceToCoVertexPerimeter)
								{
									if(PerimeterDistanceToCoVertex>0)
									{
			  			Shape ellipse = new Ellipse(PerimeterDistanceToVertex,PerimeterDistanceToCoVertex);
			  			Console.WriteLine("Perimeter = {0}",ellipse.Perimeter());
									}
									else
									Console.WriteLine("Enter the positive numbers greater then zero only");
								}
								else
								Console.WriteLine("Enter the numbers only");
							}
							else
							Console.WriteLine("Enter the positive numbers greater then zero only");
						}
			  			else
						Console.WriteLine("Enter the numbers only");
			break;
			
		default:Console.WriteLine("You have made wrong choice");
			    break;
  }
		     Console.WriteLine("Press 1 to continue");
			  Int32.TryParse(Console.ReadLine(),out WantToContinue);
	  }
		  while(WantToContinue==1);
	      Console.WriteLine("You have made wrong choice");
}
	
  public void Default()
  {
    Console.WriteLine("You have made wrong choice.");
  }
}

public class main
{
  public static void Main()
  {
	  Calculation calculation=new Calculation();
	  
	  int WantToContinue=0;
	  do
	  {
      int choice;
	  Console.WriteLine("Input the choice.\n1.Press 1 for Square\n2.Press 2 for Rectangle\n3.Press 3 for Circle\n4.Press 4 for Ellipse");
	  Int32.TryParse(Console.ReadLine(),out choice);
	  
	  switch(choice)
	  {
		  case 1: calculation.SquareCalculation();
			      break;
			  
		  case 2: calculation.RectangleCalculation();
			      break;
			  
		  case 3: calculation.CircleCalculation();
			      break;
			  
		  case 4: calculation.EllipseCalculation();
			      break;
			  
		  default:calculation.Default();
			      break;
	  }
		  Console.WriteLine("Press 1 to continue");
		  Int32.TryParse(Console.ReadLine(),out WantToContinue);
	 }while(WantToContinue==1);
	  Console.WriteLine("Invalid Input Detected.\nProgram ends.");
  }
}
