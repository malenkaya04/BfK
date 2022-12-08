using System;
	public class logOp {
		public static void Main() {
			
			int age;
			string parentalConsent;

			Console.WriteLine("Please enter a age");
			age = Convert.ToInt32(Console.ReadLine());

			if (age >= 18) {
				Console.WriteLine("Person has full legal capacity. Contract is legally binding");
			}
			else if (age >= 7) {
				Console.WriteLine("Does the person have the permisson of their parents or legal guardian?");
				parentalConsent = Console.ReadLine();
				parentalConsent = parentalConsent.ToLower();
				switch (parentalConsent) {
					case "yes": case "ja":
						Console.WriteLine("Person has limited legal capacity and has permission of a parent or legal guardian. Contract is legally binding");
						break;
					case "no": case "nein":
						Console.WriteLine("Person has limited legal capacity but not the permission of a parent or legal guardian. Contract is void");
						break;
					default:
						Console.WriteLine("Couldn't recognize if the person has permission of a parent or legal guardian. Please try again!");
						Main();
						break;
				}
			}
			else {
				Console.WriteLine("Person has no legal capacity. Contract is void");
			}
		}
	}



