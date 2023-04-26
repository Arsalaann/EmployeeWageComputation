namespace EmployeeWage{
    class CheckEmployee{
        public static void CheckAttendance(){
            int IS_FULL_TIME=1;
            Random rnd=new Random();
            int empCheck=rnd.Next(2);
            if(empCheck==IS_FULL_TIME)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is not present");
        }
    } 
}
