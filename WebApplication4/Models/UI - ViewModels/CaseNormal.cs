using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Web.Mvc;
using System.Collections.Generic;


// VIEWModel for Creating a Case 
// And Defining all the UI Constraints for the Screen.

namespace WebApplication4.UIModels
{

    // https://stackoverflow.com/questions/11064316/what-is-viewmodel-in-mvc

   

    // Appempt for a Model of a Search Screen 
    public class SearchCaller
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }

        public string Telephone1 { get; set; }

        public string  Telephone2 { get; set; }


        // This is the Array of Search results. (Uses the Generic Namespace.)
        public List <SearchResult>  DaSearchResults { get; set; }




    }

    // Class Containing The Saerch Results 
    public class SearchResult
    {
        public int Callerid { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Gender { get; set; }

        public string Telephone1 { get; set; }

        public string Telephone2 { get; set; }

    }



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

        [Required, Display(Name = "First Name:"), MaxLength(100)]
        public string Name { get; set; }

        [Required, Display(Name = "Surname:"), MaxLength(100)]
        public string Surname { get; set; }

        [Display(Name = "Age Group:")]
        public string Age { get; set; }

        [Required, Display(Name = "Gender:")]
        public string Sex { get; set; }

        [Required, Display(Name = "Race:")]
        public string Race { get; set; }

        [Display(Name = "Occupation::"), MaxLength(50)]
        public string Occupation { get; set; }

        [Display(Name = "Medical Aid:")]
        public string MedicalAid { get; set; }

        [Display(Name = "Medication:")]
        public string Medication { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

       [Display(Name="Province")] 
        public string Province { get; set; }

        [Display(Name = "Postal Code"),MaxLength(4)]
        public string PostalCode { get; set; }

        [Required]
        public string Telephone1 { get; set; }

        public string Telephone2 { get; set; }

        // THIS VALIDATION DOES NOT WORK JACK SHIT
        [Required, Display(Name = "E-Mail"), EmailAddress]
        [RegularExpression(@"^\S*$", ErrorMessage = "Email Address cannot have white spaces")]
        public string EmailAddress { get; set; }


        public string Suburb { get; set; }

        public string DLLocation { get; set; }

        public string DLType { get; set; }

        public string DLSource { get; set; }

        public string DLStudentNumber { get; set; }

        [Required]
        public string Counsellor { get; set; }

        // DatePicker on UI
        [Required]
        public Nullable<System.DateTime> CallDate { get; set; }
        // public Nullable<System.DateTime> CallDate { get; set; } = DateTime.Now;

        [Display(Name = "ADHD")]
        public bool ReasonADHD { get; set; }

        [Display(Name = "Alzheimers Dementia")]
        public bool  ReasonAlzheimersDementia { get; set; }

        [Display(Name = "Anxiety")]
        public bool  ReasonAnxiety { get; set; }

        [Display(Name = "Bipolar")]
        public bool  ReasonBipolar { get; set; }

        [Display(Name = "Debt Poverty Unemployment")]
        public bool  ReasonDebtPovertyUnemployment { get; set; }

        [Display(Name = "Depression")]
        public bool  ReasonDepression { get; set; }

        [Display(Name = "Eating Disorder")]
        public bool  ReasonEatingDisoirder { get; set; }

        [Display(Name = "HIV / AIDS")]
        public bool  ReasonHIVAIDS { get; set; }

        [Display(Name = "Information")]
        public bool  ReasonInformation { get; set; }

        [Display(Name = "Loss / Grief / Loneliness")]
        public bool  ReasonLossGriefLoneliness { get; set; }

        [Display(Name = "None")]
        public bool  ReasonNone { get; set; }

        [Display(Name = "OCD")]
        public bool  ReasonOCD { get; set; }

        [Display(Name = "Other Illness")]
        public bool  ReasonOtherIllness { get; set; }

        [Display(Name = "Physical Emotional Abuse")]
        public bool  ReasonPhysicalEmotionalAbuse { get; set; }

        [Display(Name = "Post natal Depression")]
        public bool  ReasonPostNatalDepression { get; set; }

        [Display(Name = "PTSD Trauma")]
        public bool  ReasonPTSDTrauma { get; set; }

        [Display(Name = "Relationship / Domestic Abuse")]
        public bool  ReasonReationshipDomesticAbuse { get; set; }

        [Display(Name = "Schizophrenia")]
        public bool  ReasonSchizophrenia { get; set; }

        [Display(Name = "Self Mutilation")]
        public bool  ReasonSelfMutilation { get; set; }

        [Display(Name = "Sexual Abuse / Rape")]
        public bool  ReasonSexualAbuseRape { get; set; }

        [Display(Name = "Sleeping Dissorder")]
        public bool  ReasonSleepingDisorder { get; set; }

        [Display(Name = "Social Phobia")]
        public bool  ReasonSocialPhobia { get; set; }

        [Display(Name = "Stress")]
        public bool  ReasonStress { get; set; }

        [Display(Name = "Substance Abuce")]
        public bool  ReasonSubstanceAbuse { get; set; }

        [Display(Name = "Suicide")]
        public bool  ReasonSuicide { get; set; }

        [Display(Name = "SADAG Face to Face")]
        public bool  ReferDASGFaceToFace { get; set; }

        [Display(Name = "General Practitioner")]
        public bool  ReferGP { get; set; }

        [Display(Name = "Government Hospital")]
        public bool  ReferGovHospital { get; set; }

        [Display(Name = "Literature / Web site")]
        public bool  ReferLiteratureWebsite { get; set; }

        [Display(Name = "None")]
        public bool  ReferNone { get; set; }

        [Display(Name = "Other")]
        public bool  ReferOther { get; set; }

        [Display(Name = "NGO Helpline")]
        public bool  ReferOtherNGOHelpline { get; set; }

        [Display(Name = "Police Station")]
        public bool  ReferPoliceStation { get; set; }

        [Display(Name = "Private Hospital")]
        public bool  ReferPrivateHospital { get; set; }

        [Display(Name = "Psychiatrist")]
        public bool  ReferPsychiatrist { get; set; }

        [Display(Name = "Psychologist")]
        public bool  ReferPsychologist { get; set; }

        [Display(Name = "Rape Crisis")]
        public bool  ReferRapeCrisis { get; set; }

        [Display(Name = "Shelter")]
        public bool  ReferShelter { get; set; }

        [Display(Name = "Social Worker")]
        public bool  ReferSocialWorker { get; set; }

        [Display(Name = "Support Group")]
        public bool  ReferSupportGroup { get; set; }

        [Display(Name = "Trauma Centre")]
        public bool  ReferTraumaCentre { get; set; }

        [Required, MaxLength(2000)]
        public string CallSummary { get; set; }

        [Display(Name = "Frequent Caller")]
        public bool  ReasonFrequentCaller { get; set; }

        [Display(Name = "Bullying")]
        public bool  ReasonBullying { get; set; }

        [Display(Name = "Pregnancy")]
        public bool  ReasonPregnancy { get; set; }

        [Display(Name = "Sexuallity")]
        public bool  ReasonSexuality { get; set; }

        [Display(Name = "Rehab Center")]
        public bool  ReferRehabilitationCentre { get; set; }

        [Display(Name = "Borderline Personality Disorder")]
        public bool  ReasonBorderlinePersonalityDisorder { get; set; }

        [Required]
        public string HelpLine { get; set; }

        [Display(Name = "Other Reason")]
        public bool  ReasonOtherReason { get; set; }

        [Display(Name = "Follow-up")]
        public bool  ReasonFollowUp { get; set; }

        [Display(Name = "University Student Wellness")]
        public bool  ReferUniversityStudentWellness { get; set; }

        [Display(Name = "SADAG Helpline")]
        public bool  ReferSadagHelpLine { get; set; }

        [Display(Name = "Self help")]
        public bool  ReferSelfHelp { get; set; }

        [Display(Name = "Uber")]
        public bool  ReferUber { get; set; }

        // Dropdown
        [Required, Display(Name="Time:")]
        public string DLCallTimeOfDay { get; set; }

        // Dropdown 
        [Required]
        public string CalledOnBehalfOf { get; set; }


        [Required, MinLength(100)]
        public string ActionPoints { get; set; }

        [Display(Name = "Relationship - Romantic Issues")]
        public bool  ReasonRelationshipRomanticIssues { get; set; }

        [Display(Name = "Relationship - Family Issues")]
        public bool  ReasonRelationshipFamilyIssues { get; set; }

        [Display(Name = "Company EAP")]
        public bool  ReferCompanyEAP { get; set; }

        [Display(Name = "University Support Services")]
        public bool  ReferUniversitySupportServices { get; set; }

        [Required, Display(Name="Beginning of call")]
        public int DistressRatingBegining { get; set; }

        [Required, Display(Name = "End of call")]
        public int DistressRatingEnd { get; set; }

    }

    public class CaseDedicaledLine
    {
        [Required, Display(Name = "The First Name")]
        public string Name { get; set; }
    }


    // TESTING 123 - WIP CODE
    public class FrequencyReport
    {
        [Display(Name="Measure")]
        public string Measure { get; set; }

        public int Jan { get; set; }

        public int Feb { get; set; }

        public int Mar { get; set; }

        public int Apr { get; set; }

        public int May { get; set; }

        public int Jun { get; set; }

        public int Jul { get; set; }

        public int Aug { get; set; }

        public int Sep { get; set; }

        public int Oct { get; set; }

        public int Nov { get; set; }

        public int Des { get; set; }

        public int Total { get; set; }


    }



}

