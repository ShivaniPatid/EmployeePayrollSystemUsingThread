using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollService
{
    public class AddEmployeeDetails
    {
        public void AddingEmployees()
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Bruce", PhoneNumber: "1234567890", Address: "Ujjian", Department: "HR", Gender: 'M', BasicPay: 10000, Deduction: 5000, TaxablePay:2000, Tax:1000, NetPay:500, City:"Ujjain", Country:"India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 2, EmployeeName: "Wayne", PhoneNumber: "1234567890", Address: "Ujjian", Department: "Manager", Gender: 'M', BasicPay: 10000, Deduction: 5000, TaxablePay: 2000, Tax: 1000, NetPay: 500, City: "Ujjain", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 3, EmployeeName: "Peter", PhoneNumber: "1234567890", Address: "Ujjian", Department: "Sales", Gender: 'M', BasicPay: 10000, Deduction: 5000, TaxablePay: 2000, Tax: 1000, NetPay: 500, City: "Ujjain", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 4, EmployeeName: "Rita", PhoneNumber: "1234567890", Address: "Ujjian", Department: "HR", Gender: 'F', BasicPay: 10000, Deduction: 5000, TaxablePay: 2000, Tax: 1000, NetPay: 500, City: "Ujjain", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 5, EmployeeName: "Riya", PhoneNumber: "1234567890", Address: "Ujjian", Department: "HR", Gender: 'F', BasicPay: 10000, Deduction: 5000, TaxablePay: 2000, Tax: 1000, NetPay: 500, City: "Ujjain", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 6, EmployeeName: "Ajay", PhoneNumber: "1234567890", Address: "Ujjian", Department: "Manager", Gender: 'M', BasicPay: 10000, Deduction: 5000, TaxablePay: 2000, Tax: 1000, NetPay: 500, City: "Ujjain", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 7, EmployeeName: "Vijay", PhoneNumber: "1234567890", Address: "Ujjian", Department: "Manager", Gender: 'M', BasicPay: 10000, Deduction: 5000, TaxablePay: 2000, Tax: 1000, NetPay: 500, City: "Ujjain", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 8, EmployeeName: "Banner", PhoneNumber: "1234567890", Address: "Ujjian", Department: "Sales", Gender: 'M', BasicPay: 10000, Deduction: 5000, TaxablePay: 2000, Tax: 1000, NetPay: 500, City: "Ujjain", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 9, EmployeeName: "Joe", PhoneNumber: "1234567890", Address: "Ujjian", Department: "Sales", Gender: 'M', BasicPay: 10000, Deduction: 5000, TaxablePay: 2000, Tax: 1000, NetPay: 500, City: "Ujjain", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 10, EmployeeName: "Doe", PhoneNumber: "1234567890", Address: "Ujjian", Department: "Manager", Gender: 'M', BasicPay: 10000, Deduction: 5000, TaxablePay: 2000, Tax: 1000, NetPay: 500, City: "Ujjain", Country: "India"));


            EmployeePayrollOperation employeePayrollOperation = new EmployeePayrollOperation();
            DateTime startDateTime = DateTime.Now;
            employeePayrollOperation.AddEmployeeToPayroll(employeeDetails);
            DateTime stopDateTime = DateTime.Now;
            Console.WriteLine("Dureation without thread : "+(stopDateTime-startDateTime));

            DateTime startDateTimeThread = DateTime.Now;
            employeePayrollOperation.AddEmployeeToPayrollWithThread(employeeDetails);
            DateTime stopDateTimeThread = DateTime.Now;
             Console.WriteLine("Dureation without thread : " + (stopDateTimeThread - startDateTimeThread));
        }
    }
        
}
