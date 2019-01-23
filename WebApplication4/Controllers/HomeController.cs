using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FrequencyReport()
        {

            // DATABSE COPNTEXT VARIABLE I CREATE 
            var DaContext = new WebApplication4.Models.Db.DAISYEntities();


            // Fetch all the row of the context and passs it to the View
            var ReporData = DaContext.Stats_By_Race___RN.ToList();

            // We need to create a collection so we can add items heere, right?
            // IEnumerable<UIModels.FrequencyReport> ReporData;

            List<UIModels.FrequencyReport> FReportItems = new List<UIModels.FrequencyReport>();        

            //
            foreach ( var DaMeasure in ReporData)
            {
                // Create New Object
                UIModels.FrequencyReport DDD = new UIModels.FrequencyReport();

                // Set the Properties
                DDD.Measure = DaMeasure.Measure.ToString();
                DDD.Jan = DaMeasure.Jan.GetValueOrDefault();
                DDD.Feb = DaMeasure.Feb.GetValueOrDefault();

                DDD.Mar = DaMeasure.Mar.GetValueOrDefault();
                DDD.Apr = DaMeasure.Apr.GetValueOrDefault();

                DDD.May = DaMeasure.May.GetValueOrDefault();
                DDD.Jun = DaMeasure.Jun.GetValueOrDefault();


                DDD.Jul = DaMeasure.Jul.GetValueOrDefault();
                DDD.Aug = DaMeasure.Aug.GetValueOrDefault();

                DDD.Sep = DaMeasure.Sep.GetValueOrDefault();
                DDD.Oct = DaMeasure.Oct.GetValueOrDefault();

                DDD.Nov = DaMeasure.Nov.GetValueOrDefault();
                DDD.Des = DaMeasure.Dec.GetValueOrDefault();

                DDD.Total = DaMeasure.Total.GetValueOrDefault();

                // ETC;
                // Add The object
                FReportItems.Add(DDD);

            }


            // Make sure teh view can acceprt an model of type IEnumerable
            return View(FReportItems);

        }




        // FrequencyReport Controller Code to diaply the Data in the Model.
        // The is no post-controller as we do not do a post from the screen.
        //    public ActionResult FrequencyReport_OLD()
        //    {

        //        // Do something here to accecc the data via the DAL 
        //        // to query the Database View and return data.

        //        var DaContext = new WebApplication4.Models.Db.DAISYEntities();

        //        // Create a UI VIEWMODEL and populate it withj data from the VIEW.

        //        // new ViewModel
        //        // https://www.red-gate.com/simple-talk/dotnet/asp-net/revisiting-partial-view-rendering-in-asp-net-mvc/


        //       IEnumerable frs <WebApplication4.Models.Db.DAISYEntities.FrequencyReport> fr =  DaContext.Stats_By_Race___RN.Where(x => x.Oct > 100).ToList()



        //        // THIS WILL GET TO A DATALAYER COLLECTION SOMEHOW.

        //       WebApplication4.UIModels.FrequencyReport frp = new WebApplication4.UIModels.FrequencyReport();



        //        foreach (var f in frs)

        //        {

        //            frp.Jan = f.Jan;
        //            frp.Feb = f.feb;
        //            frp.Des = f.Dec;
        //            frp.Total = f.Total;

        //        }           


        //       // https://stackoverflow.com/questions/27108846/how-to-map-data-access-to-business-logic-objects-in-entity-framework

        //       /*
        //       Yes, there is a bunch of left-right mapping to "convert" one class to another, 
        //       but it's a clean separation of internal business logic classes for later on. 
        //       Straight table to POCO conversions seems silly at first, but just wait until your 
        //       DBA want's to normalize a few fields or you decide to add a collection to those 
        //       simple objects.Being able to manage your business objects without breaking the rest of you app is priceless.
        //       */





        //       // Create the UI Model with data (Work on this!)
        //       WebApplication4.UIModels.FrequencyReport FC = new WebApplication4.UIModels.FrequencyReport();


        //        ViewBag.Message = "Frequency Report";

        //        return View(Helplines);

        //    }


        // SearchCaller - I Typed this stuff myself!0
        public ActionResult SearchCaller()
        {

            ViewBag.Message = "SearchCaller";


            // Call a SP to add the Model Data.
            var DaContext = new WebApplication4.Models.Db.DAISYEntities();

            // DO THE DB QUERY AND THEN MAP TO THE UI MODEL!!!!
            List<WebApplication4.Models.Db.Caller> Callers = DaContext.Callers.Where(c => c.CALLERID < 1000).ToList();

            // List<WebApplication4.Models.Db.Caller> Callers = DaContext.Callers.ToList();


            // List <WebgridOrGridview.Models.Employee> GoodEmployees = (List<WebgridOrGridview.Models.Employee>) WebgridOrGridview.Models.Employee.GetList();

            // This just gets some datato display and filter on the data according to the filter criteria specified
            // List<WebgridOrGridview.Models.Employee> empoyees = (List<WebgridOrGridview.Models.Employee>) WebgridOrGridview.Models.Employee.GetList().Where(e=>e.Salary > 65000).ToList(); //Reference of Model Class File.  
          




            return View(Callers);


            // return View();

        }


        // SearchCaller - Method for Handling a POST for teh Search

        




        // CreateCaseNormal - I Typed this stuff myself!0
        public ActionResult CreateCaseNormal()
        {

            ViewBag.Message = "Create New Case";

            return View();
      
    }

        // CreateCaseNormal - I Typed this stuff myself!
        // Thuis happpensd on the POST - When the form gets submitted back to the serevr.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCaseNormal(WebApplication4.UIModels.CaseNormal model)
        {

            // Unitil we have picked the right Day from teh screen.
            // model.CallDate = DateTime.Today;

            if (ModelState.IsValid)
            {


                // PUT THIS CRAP IN A BUSINESS-LOGIC LAYER

                // You need to map the UI Model to the Entity Framework Model


                // Call a SP to add the Model Data.
                var DaContext = new WebApplication4.Models.Db.DAISYEntities();

                //  var Calls = new                 

                DaContext.CreateCaseWrite(model.Name,
                    model.Surname,
                    model.Age,
                    model.Sex,
                    model.Race,
                    model.Occupation,
                    model.MedicalAid,
                    model.Medication,
                    model.Address,
                    model.City,
                    model.Province,
                    model.PostalCode,
                    model.Telephone1,
                    model.Telephone2,
                    model.EmailAddress,
                    model.Suburb,
                    model.DLLocation,
                    model.DLType,
                    model.DLSource,
                    model.DLStudentNumber,
                    model.Counsellor,
                    model.CallDate,
                    model.ReasonADHD,
                    model.ReasonAlzheimersDementia,
                    model.ReasonAnxiety,
                    model.ReasonBipolar,
                    model.ReasonDebtPovertyUnemployment,
                    model.ReasonDepression,
                    model.ReasonEatingDisoirder,
                    model.ReasonHIVAIDS,
                    model.ReasonInformation,
                    model.ReasonLossGriefLoneliness,
                    model.ReasonNone,
                    model.ReasonOCD,
                    model.ReasonOtherIllness,
                    model.ReasonPhysicalEmotionalAbuse,
                    model.ReasonPostNatalDepression,
                    model.ReasonPTSDTrauma,
                    model.ReasonReationshipDomesticAbuse,
                    model.ReasonSchizophrenia,
                    model.ReasonSelfMutilation,
                    model.ReasonSexualAbuseRape,
                    model.ReasonSleepingDisorder,
                    model.ReasonSocialPhobia,
                    model.ReasonStress,
                    model.ReasonSubstanceAbuse,
                    model.ReasonSuicide,
                    model.ReferDASGFaceToFace,
                    model.ReferGP,
                    model.ReferGovHospital,
                    model.ReferLiteratureWebsite,
                    model.ReferNone,
                    model.ReferOther,
                    model.ReferOtherNGOHelpline,
                    model.ReferPoliceStation,
                    model.ReferPrivateHospital,
                    model.ReferPsychiatrist,
                    model.ReferPsychologist,
                    model.ReferRapeCrisis,
                    model.ReferShelter,
                    model.ReferSocialWorker,
                    model.ReferSupportGroup,
                    model.ReferTraumaCentre,
                    model.CallSummary,
                    model.ReasonFrequentCaller,
                    model.ReasonBullying,
                    model.ReasonPregnancy,
                    model.ReasonSexuality,
                    model.ReferRehabilitationCentre,
                    model.ReasonBorderlinePersonalityDisorder,
                    model.HelpLine,
                    model.ReasonOtherReason,
                    model.ReasonFollowUp,
                    model.ReferUniversityStudentWellness,
                    model.ReferSadagHelpLine,
                    model.ReferSelfHelp,
                    model.ReferUber,
                    model.DLCallTimeOfDay,
                    model.CalledOnBehalfOf,
                    model.ActionPoints,
                    model.ReasonRelationshipRomanticIssues,
                    model.ReasonRelationshipFamilyIssues,
                    model.ReferCompanyEAP,
                    model.ReferUniversitySupportServices,
                    model.DistressRatingBegining,
                    model.DistressRatingEnd
                    );

                //      public virtual int CreateCaseWrite(string name, string surname, string age, string sex, string race, string occupation, string medicalAid, string medication, string address, string city, string province, string postalCode, string telephone1, string telephone2, string emailAddress, string suburb, string dLLocation, string dLType, string dLSource, string dLStudentNumber, string counsellor, Nullable<System.DateTime> callDate, Nullable<bool> reasonADHD, Nullable<bool> reasonAlzheimersDementia, Nullable<bool> reasonAnxiety, Nullable<bool> reasonBipolar, Nullable<bool> reasonDebtPovertyUnemployment, Nullable<bool> reasonDepression, Nullable<bool> reasonEatingDisoirder, Nullable<bool> reasonHIVAIDS, Nullable<bool> reasonInformation, Nullable<bool> reasonLossGriefLoneliness, Nullable<bool> reasonNone, Nullable<bool> reasonOCD, Nullable<bool> reasonOtherIllness, Nullable<bool> reasonPhysicalEmotionalAbuse, Nullable<bool> reasonPostNatalDepression, Nullable<bool> reasonPTSDTrauma, Nullable<bool> reasonReationshipDomesticAbuse, Nullable<bool> reasonSchizophrenia, Nullable<bool> reasonSelfMutilation, Nullable<bool> reasonSexualAbuseRape, Nullable<bool> reasonSleepingDisorder, Nullable<bool> reasonSocialPhobia, Nullable<bool> reasonStress, Nullable<bool> reasonSubstanceAbuse, Nullable<bool> reasonSuicide, Nullable<bool> referDASGFaceToFace, Nullable<bool> referGP, Nullable<bool> referGovHospital, Nullable<bool> referLiteratureWebsite, Nullable<bool> referNone, Nullable<bool> referOther, Nullable<bool> referOtherNGOHelpline, Nullable<bool> 
                //          , Nullable<bool> , Nullable<bool> referTraumaCentre, string callSummary, Nullable<bool> reasonFrequentCaller, Nullable<bool> reasonBullying, Nullable<bool> 
                //          reasonPregnancy, Nullable<bool> reasonSexuality, Nullable<bool> 
                //          referRehabilitationCentre, Nullable<bool> 
                //          , string helpLine, Nullable<bool> reasonOtherReason, Nullable<bool> 
                //          reasonFollowUp, Nullable<bool> referUniversityStudentWellness, Nullable<bool> referSadagHelpLine, Nullable<bool> 
                //          referSelfHelp, Nullable<bool> referUber, string 


                //dLCallTimeOfDay, string , string actionPoints, Nullable<bool> reasonRelationshipRomanticIssues, 
                //          Nullable<bool> reasonRelationshipFamilyIssues, Nullable<bool> referCompanyEAP, Nullable<bool> 
                //          referUniversitySupportServices, Nullable<int> distressRatingBegining, Nullable<int> distressRatingEnd)

                int i = DaContext.SaveChanges();              

                return RedirectToAction("Index");
            }
            else
            {
                // MODELSLATE INVALID - SO SOMETING SUBMITTED WAS WRONG! (CALLDATE?)

                int i = 0;


                foreach (var V in ModelState.Values)
                {

                    if (V.Errors.Count > 0)
                    {

                        int o = 1;

                    }

                }
                
            }




            return View();

        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        // Controller text for AJAX
        // THIS QUERIOES TEH DATABASE VIA ENTITY FRAMEWORK 
        // AND RETURNS A LIST OF COUNSELLORS for the UI DROPDOWN
        public JsonResult ReturnJSONCounsellorDataToAJax() //It will be fired from Jquery ajax call  
        {
            var DaContext = new WebApplication4.Models.Db.DAISYEntities();

            // LAMBDA EXPRESSION FILTERS ON THE ACTIVE ONES ONLY -> THIS WORKS
            // https://stackoverflow.com/questions/16185514/linq-query-or-lambda-expression

            var jsonData = DaContext.Counsellors.Where(c=> c.Active == true).ToList();

            // jsonData[1].Active

            return Json(jsonData, JsonRequestBehavior.AllowGet);  

        }


        public JsonResult ReturnJSONHelplineDataToAJax() //It will be fired from Jquery ajax call  
        {
            var DaContext = new WebApplication4.Models.Db.DAISYEntities();

            // LAMBDA EXPRESSION FILTERS ON THE ACTIVE ONES ONLY -> THIS WORKS
            // https://stackoverflow.com/questions/16185514/linq-query-or-lambda-expression

            var jsonData = DaContext.Helplines.Where(c=>c.Active==true).ToList();

            // jsonData[1].Helpline1

            return Json(jsonData, JsonRequestBehavior.AllowGet);

        }



        public JsonResult ReturnJSONCallTimeOfDayDataToAJax() //It will be fired from Jquery ajax call  
        {
            var DaContext = new WebApplication4.Models.Db.DAISYEntities();

            // LAMBDA EXPRESSION FILTERS ON THE ACTIVE ONES ONLY -> THIS WORKS
            // https://stackoverflow.com/questions/16185514/linq-query-or-lambda-expression

            var jsonData = DaContext.DLTimes.ToList();

            // jsonData[1].Helpline1

            return Json(jsonData, JsonRequestBehavior.AllowGet);

        }




    }
}