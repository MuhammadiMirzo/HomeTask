namespace Domain;

public class GetManagers
{
    public int  ManagerId { get; set; }
    public string 	ManagerFullName { get; set; }
    public int  DepartmentId { get; set; }
    public string  	DepartmentName { get; set; }
    public DateTime FromDate { get; set; }
    public DateTime ToDate { get; set; }
    
}

public class InsertManager
{
    public int EmployeeId { get; set; }
    public int DepartmentId { get; set; }
 	
     public DateTime FromDate { get; set; }
     public DateTime ToDate { get; set; }
 	

}

