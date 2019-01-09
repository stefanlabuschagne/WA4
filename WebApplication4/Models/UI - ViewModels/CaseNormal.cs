using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Web.Mvc;


// VIEWModel for Creating a Case 
// And Defining all the UI Constraints for the Screen.

namespace WebApplication4.UIModels
{



    // https://stackoverflow.com/questions/11064316/what-is-viewmodel-in-mvc

   
    public class SearchCaller
    { }


    public class SearchCalls
    { }



    // THE CLASSNAME CANNOT BE THE SAME AS THE EF CLASSES IN THE SAME ASSEMBLY (Webapplication4)
    // TO RESOLVE THIS, WE NEED TO CEEATE A SEPARATE ASSEMBLY (Destop Application for the DATABASE MODELS in ENTITY FRAMEWORK)
    // Or Hack it this way.
    // This is for adding and editing a Counsellor
    public class CounsellorUI
    {
        [Required, MinLength(6)]
        public string Counsellor1 { get; set; }  // Because it cant be the same as the Classname
        public bool Active { get; set; }

    }



    // This is A UI VIEW-Model to Create Cases
    public class CaseNormal

    {

        // public CaseNormal { get; set; }


        [Required, Display(Name = "The First Name")]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public string Age { get; set; }

        [Required, Display(Name = "Gender")]
        public string Sex { get; set; }

        [Required]
        public string Race { get; set; }
        public string Occupation { get; set; }
        public string MedicalAid { get; set; }
        public string Medication { get; set; }
        public string Address { get; set; }
        public string City { get; set; }


        public string Province { get; set; }
        public string PostalCode { get; set; }

        [Required]
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string EmailAddress { get; set; }
        public string Suburb { get; set; }
        public string DLLocation { get; set; }
        public string DLType { get; set; }
        public string DLSource { get; set; }
        public string DLStudentNumber { get; set; }

        [Required]
        public string Counsellor { get; set; }

        public Nullable<System.DateTime> CallDate { get; set; }

        public Nullable<bool> ReasonADHD { get; set; }
        public Nullable<bool> ReasonAlzheimersDementia { get; set; }
        public Nullable<bool> ReasonAnxiety { get; set; }
        public Nullable<bool> ReasonBipolar { get; set; }
        public Nullable<bool> ReasonDebtPovertyUnemployment { get; set; }
        public Nullable<bool> ReasonDepression { get; set; }
        public Nullable<bool> ReasonEatingDisoirder { get; set; }
        public Nullable<bool> ReasonHIVAIDS { get; set; }
        public Nullable<bool> ReasonInformation { get; set; }
        public Nullable<bool> ReasonLossGriefLoneliness { get; set; }
        public Nullable<bool> ReasonNone { get; set; }
        public Nullable<bool> ReasonOCD { get; set; }
        public Nullable<bool> ReasonOtherIllness { get; set; }
        public Nullable<bool> ReasonPhysicalEmotionalAbuse { get; set; }
        public Nullable<bool> ReasonPostNatalDepression { get; set; }
        public Nullable<bool> ReasonPTSDTrauma { get; set; }
        public Nullable<bool> ReasonReationshipDomesticAbuse { get; set; }
        public Nullable<bool> ReasonSchizophrenia { get; set; }
        public Nullable<bool> ReasonSelfMutilation { get; set; }
        public Nullable<bool> ReasonSexualAbuseRape { get; set; }
        public Nullable<bool> ReasonSleepingDisorder { get; set; }
        public Nullable<bool> ReasonSocialPhobia { get; set; }
        public Nullable<bool> ReasonStress { get; set; }
        public Nullable<bool> ReasonSubstanceAbuse { get; set; }
        public Nullable<bool> ReasonSuicide { get; set; }
        public Nullable<bool> ReferDASGFaceToFace { get; set; }
        public Nullable<bool> ReferGP { get; set; }
        public Nullable<bool> ReferGovHospital { get; set; }
        public Nullable<bool> ReferLiteratureWebsite { get; set; }
        public Nullable<bool> ReferNone { get; set; }
        public Nullable<bool> ReferOther { get; set; }
        public Nullable<bool> ReferOtherNGOHelpline { get; set; }
        public Nullable<bool> ReferPoliceStation { get; set; }
        public Nullable<bool> ReferPrivateHospital { get; set; }
        public Nullable<bool> ReferPsychiatrist { get; set; }
        public Nullable<bool> ReferPsychologist { get; set; }
        public Nullable<bool> ReferRapeCrisis { get; set; }
        public Nullable<bool> ReferShelter { get; set; }
        public Nullable<bool> ReferSocialWorker { get; set; }
        public Nullable<bool> ReferSupportGroup { get; set; }
        public Nullable<bool> ReferTraumaCentre { get; set; }

        [Required]
        public string CallSummary { get; set; }

        public Nullable<bool> ReasonFrequentCaller { get; set; }
        public Nullable<bool> ReasonBullying { get; set; }
        public Nullable<bool> ReasonPregnancy { get; set; }
        public Nullable<bool> ReasonSexuality { get; set; }
        public Nullable<bool> ReferRehabilitationCentre { get; set; }
        public Nullable<bool> ReasonBorderlinePersonalityDisorder { get; set; }
        public string HelpLine { get; set; }
        public Nullable<bool> ReasonOtherReason { get; set; }
        public Nullable<bool> ReasonFollowUp { get; set; }
        public Nullable<bool> ReferUniversityStudentWellness { get; set; }
        public Nullable<bool> ReferSadagHelpLine { get; set; }
        public Nullable<bool> ReferSelfHelp { get; set; }
        public Nullable<bool> ReferUber { get; set; }
        public string DLCallTimeOfDay { get; set; }
        public string CalledOnBehalfOf { get; set; }
        public string ActionPoints { get; set; }
        public Nullable<bool> ReasonRelationshipRomanticIssues { get; set; }
        public Nullable<bool> ReasonRelationshipFamilyIssues { get; set; }
        public Nullable<bool> ReferCompanyEAP { get; set; }
        public Nullable<bool> ReferUniversitySupportServices { get; set; }

        [Required, DefaultValue(3)]
        public Nullable<int> DistressRatingBegining { get; set; }

        [Required, DefaultValue(3)]
        public Nullable<int> DistressRatingEnd { get; set; }

    }

    public class CaseDedicaledLine
    {
        [Required, Display(Name = "The First Name")]
        public string Name { get; set; }
    }




}

