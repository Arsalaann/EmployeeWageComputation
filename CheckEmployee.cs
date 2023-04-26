namespace EmployeeWage{
    class CheckEmployee{
        public static void CheckAttendance(){
            int EMP_RATE_PER_HOUR=20;
            int IS_FULL_TIME=1;
            int empHour=0;
            int empWage=0;
            Random rnd=new Random();
            int empCheck=rnd.Next(2);
            if(empCheck==IS_FULL_TIME)
                empHour=8;
            else
                empHour=0;
            int Employee=EMP_RATE_PER_HOUR*empHour;
            Console.WriteLine("Employee : "+Employee);
        }
    } 
}
