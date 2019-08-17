/* Name Of Program: Payroll Program.cpp
 Name: Jessica Alexander
 Date: 01/24/2019
 Chapter: 3 */


#include "pch.h"
#include <iostream>
#include <string>
#include<iomanip>
#include <fstream>

using namespace std;

int main()
{
	ofstream Outfile;
	ofstream Outfile("C:Payroll.txt");
	
	string empName;
	int totalHoursWorked = 0;
	int overTimeHoursWorked = 0;
	double rateOfPay;
	double grossPayRegularHours = 0;
	double grossPayOvertimeHours = 0;
	double totalGrossPay = 0;
	double insuranceDeduction;
	double retirementDeduction;
	double taxesFICA;
	double netPay;

	cout << "Enter Employee Name: ";
	getline(cin, empName);

	cout << "Enter Total Hours Worked in Week: ";
	cin >> totalHoursWorked;

	cout << "Enter Rate of Pay: ";
	cin >> rateOfPay;

	if (totalHoursWorked > 40)
	{
		overTimeHoursWorked = totalHoursWorked - 40;
	}

	grossPayRegularHours = totalHoursWorked * rateOfPay;
	grossPayOvertimeHours = overTimeHoursWorked * rateOfPay * 1.5;
	totalGrossPay = grossPayRegularHours + grossPayOvertimeHours;

	char insurance;
	cout << "Participated in Insurance Plan: ";
	cin >> insurance;
	if (insurance == 'y' || insurance == 'Y')
	{
		insuranceDeduction = 75;
	}
	else
	{
		insuranceDeduction = 0;
	}

	char retirement;
	cout << "Participated in Retirement Plan: ";
	cin >> retirement;

	if (retirement == 'y' || retirement == 'Y')
	{
		retirementDeduction = totalGrossPay * 0.06;
	}
	else
	{
		retirementDeduction = 0;
	}


	cout << "Total Gross Pay: " << totalGrossPay << endl;

	totalGrossPay = totalGrossPay - (insuranceDeduction - retirementDeduction);
	taxesFICA = totalGrossPay * 0.23;
	netPay = totalGrossPay - taxesFICA;

	cout << "Net Pay: " << netPay;

	if (Outfile.is_open())
	{
		Outfile << setfill('.');
		Outfile << setw(20) << empName << endl;
		Outfile << setw(20) << totalHoursWorked << endl;
		Outfile << setw(20) << overTimeHoursWorked << endl;
		Outfile << setw(20) << rateOfPay << endl;
		Outfile << left << setw(20) << "Regular Pay: " << "$" << right << setw(7) << grossPayRegularHours << endl;
		Outfile << left << setw(20) << "Overtime Pay: " << "$" << right << setw(7) << grossPayOvertimeHours << endl;
		Outfile << left << setw(20) << "Gross Pay: " << "$" << right << setw(7) << totalGrossPay << endl;
		Outfile << left << setw(20) << "Insurance Deduction: " << "$" << right << setw(7) << insuranceDeduction << endl;
		Outfile << left << setw(20) << "Retirenment Deduction: " << "$" << right << setw(7) << retirementDeduction << endl;
		Outfile << left << setw(20) << "FICA Taxes: " << "$" << right << setw(7) << taxesFICA << endl;
		Outfile << left << setw(20) << "Net Pay: " << "$" << right << setw(7) << netPay << endl;
		Outfile.close();
	}
	else
	{
		cout << "File Not Found.....";
	}


	cout << setfill('.');
	cout << fixed << showpoint << setprecision(2);
	cout << setw(20) << empName << endl;
	cout << setw(20) << totalHoursWorked << endl;
	cout << setw(20) << overTimeHoursWorked << endl;
	cout << setw(20) << rateOfPay << endl;
	cout << left << setw(20) << "Regular Pay: " << "$" << right << setw(7) << grossPayRegularHours << endl;
	cout << left << setw(20) << "Overtime Pay: " << "$" << right << setw(7) << grossPayOvertimeHours << endl;
	cout << left << setw(20) << "Gross Pay: " << "$" << right << setw(7) << totalGrossPay << endl;
	cout << left << setw(20) << "Insurance Deduction: " << "$" << right << setw(7) << insuranceDeduction << endl;
	cout << left << setw(20) << "Retirenment Deduction: " << "$" << right << setw(7) << retirementDeduction << endl;
	cout << left << setw(20) << "FICA Taxes: " << "$" << right << setw(7) << taxesFICA << endl;
	cout << left << setw(20) << "Net Pay: " << "$" << right << setw(7) << netPay << endl;

	return 0;

}