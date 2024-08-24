using System;

namespace Samples.OOP
{
	public class MyDate
	{
	uint day = 1;
	uint month = 1;
	uint year;
	
	public MyDate(uint day,
	uint month,
	uint year){
		this.day = day;
		this.month = month;
		this.year = year;
	}
	
	public MyDate(MyDate date){
		this.day = date.day;
		this.month = date.month;
		this.year = date.year;
	}
	
	public MyDate AddDays(uint moreDays){
		MyDate newDate = new MyDate(this);
		newDate.day = newDate.day + moreDays; 
		return newDate;
	}
	
	public string ToShortString()
	{
		return string.Format("{0}/{1}/{2}",this.day,
		this.month
		,this.year.ToString().Substring(2));
	}
	
	public override string ToString(){
		return ""+ day + "/"  + month + "/" + year;
	}
	
	public static void Main(string[] args){
		MyDate mydate = new MyDate(21,08,2017);
		Console.WriteLine();
		Console.WriteLine("ToString: {0}",mydate.ToString());
		mydate = mydate.AddDays(3);
		Console.WriteLine("ToShortString: {0}",mydate.ToShortString());
	}
	}
}
