using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
	//Liskov substituion principle


	// Parent class and child class

	//parent and child class
	//subclasses shoul dbe replacebale for thier parent classes without breaking the program.

	public class rectangle
	{

		public int width;
		public int height;

		public virtual void setWidth(int w)
		{
			width = w;
		}

		public virtual void setHeight(int h)
		{
			height = h;
		}

		public int GetArea()
		{
			return width * height;
		}

	}


	public class Square : rectangle
	{

		public override void setWidth(int w)
		{
			width = w;
			height = w;    // force height same as width
		}


		public override void setHeight(int h)
		{
			width = h;    //force width same as height
			height = h;
		}

	}


	public class LSPProgram
	{

		public static void Main()
		{
			rectangle r = new Square();   //Demos

			r.setWidth(5);
			r.setHeight(10);


			r.GetArea(); //100   //50
		}
		


	}



}
