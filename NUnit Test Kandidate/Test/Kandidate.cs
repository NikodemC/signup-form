using System;
using System.Diagnostics.Tracing;
using NUnit.Framework;
using NUnitTestKandidate.PageObjects;

namespace NUnitTestKandidate.Test
{
    [TestFixture]
    class Kandidate : Core.BaseTest

    {
        [Test]
        public void OpenChromeCoreKandidate()
        {
            action.Click(SignupPage1.further_button, "Start");
            action.Type(SignupPage1.name_input, "AutoTest", "Name Input");
            action.Type(SignupPage1.surname_input, "AutoTest", "Surname Input");
            action.Click(SignupPage1.citizenship_input,"Citizenship Field");
            action.Click(SignupPage1.citizenship_input1,"Citizenship Selection");
            action.Click(SignupPage1.next_button,"Next button");

            action.Click(SignupPage2.Is_graduate, "Is graduate");
            action.Type(SignupPage2.YEO_input,"3","YEO");
            action.Click(SignupPage2.Sector, "Sector");
            action.Type(SignupPage2.Job_title, "AutoTest", "job title");
            action.Type(SignupPage2.Description, "AutoTest", "job description");
            action.Click(SignupPage2.further_button, "Next button");

            action.Type(SignupPage3.RoleDesc, "AutoTest", "Role description");
            action.Click(SignupPage3.IdealRole, "Ideal role");
            action.Type(SignupPage3.IdealRoleYears, "2", "Ideal role years");
            action.Click(SignupPage3.Tools, "Tools");
            action.Click(SignupPage3.Location, "Location");
            action.Type(SignupPage3.SalaryExp, "30000", "Salary expectations");
            action.Click(SignupPage3.NextButton, "Next page");


            System.Random rand = new Random();
            var num = rand.Next(9, 999999);

            action.Type(SignupPage4.Email, $"nikodem+{num}@kandidate.com", "email");
            action.Click(SignupPage4.Language1, "language1");
            action.Click(SignupPage4.Language2, "language2");
            action.Click(SignupPage4.Email, "email");
            action.Click(SignupPage4.Date1, "Date1");
            action.Click(SignupPage4.Date2, "Date2");
            action.Type(SignupPage4.Location, "Warsaw", "Location");
            action.Type(SignupPage4.Password, "Password123", "password");
            action.Click(SignupPage4.ContactedBy, "contacted by");
            action.Click(SignupPage4.CompleteBtn, "complete");
        }
    }
}