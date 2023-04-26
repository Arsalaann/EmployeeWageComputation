namespace EmployeeWage{
    class CheckEmployee{
        public static void CheckAttendance(){
            int EMP_RATE_PER_HOUR=20;
            int IS_FULL_TIME=1;
            int IS_PART_TIME=2;
            int empHour=0;
            int empWage=0;
            Random rnd=new Random();
            int empCheck=rnd.Next(3);
            if(empCheck==IS_FULL_TIME)
                empHour=8;
            else if(empCheck==IS_PART_TIME)
                empHour=4;
            else
                empHour=0;
            empWage=EMP_RATE_PER_HOUR*empHour;
            Console.WriteLine("Employee Wage: "+empWage);
        }
    } 
}
