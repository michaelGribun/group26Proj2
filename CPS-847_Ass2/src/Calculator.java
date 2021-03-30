import java.util.Scanner;

public class Calculator{
	public static void main(String args[]){
		try {
			String oper = "";
			double num1;
			double num2;
			double res = 0;
			if(args.length == 3) {
				num1 = Double.parseDouble(args[0]);
				num2 = Double.parseDouble(args[1]);
				oper = args[2];
			} else {
				Scanner in = new Scanner(System.in);
				System.out.println("Enter your first number: ");
				num1 = in.nextDouble();
				System.out.println("Enter your second number: ");
				num2 = in.nextDouble();
				System.out.println("Enter your operation (add, subtract, multiply, divide)");
				oper = in.next();
				oper = oper.toLowerCase().trim();
			}
			if(oper.equals("add")) {
				res = addThem(num1, num2);
			}
			else if(oper.equals("subtract")) {
				res = subtractThem(num1, num2);
			}
			else if(oper.equals("multiply")) {
				res = multiplyThem(num1, num2);
			}
			else if(oper.equals("divide")) {
				res = divideThem(num1, num2);
			}
			System.out.println("The answer to your operation was: " + res);
			
			
		} catch(Exception e) {
			System.out.println("Something was wrong with your input. Here's the stack trace: ");
			e.printStackTrace();
		}
		
	}
	
	public static double addThem(double a, double b) {
		System.out.println("Adding...");
		return a + b;
	}
	
	public static double subtractThem(double a, double b) {
		System.out.println("Subtracting...");
		return a - b;
	}
	
	public static double multiplyThem(double a, double b) {
		System.out.println("Multiplying...");
		return a * b;
	}
	
	public static double divideThem(double a, double b) {
		System.out.println("Dividing...");
		if(b != 0) return a / b;
		else {
			System.out.println("Can't divide by 0... returning 0");
			return 0;
		}
	}
}