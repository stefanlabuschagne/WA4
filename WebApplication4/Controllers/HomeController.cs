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

                DaContext.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                // MODELSLATE INVALID - SO SOMETING SUBMITTED WAS WRONG! (CALLDATE?)

                int i = 0;
                
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