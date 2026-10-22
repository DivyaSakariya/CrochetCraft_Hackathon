using System.ComponentModel.DataAnnotations;
namespace CrochetCraft.Models;
public class RegisterVm { [Required] public string Name {get;set;}="";[Required,EmailAddress] public string Email {get;set;}="";[Required,MinLength(6),DataType(DataType.Password)] public string Password {get;set;}=""; }
public class LoginVm { [Required,EmailAddress] public string Email {get;set;}="";[Required,DataType(DataType.Password)] public string Password {get;set;}=""; }
public class DesignVm { [Range(1,100000)] public int ProductId {get;set;} [Required] public string Color {get;set;}="Rose";[Required] public string Size {get;set;}="Medium";[Required] public string Pattern {get;set;}="Classic";[MaxLength(40)] public string PersonalName {get;set;}="";public bool Bow {get;set;} public bool GiftWrap {get;set;} [Range(1,100)] public int Quantity {get;set;}=1; }
public class CheckoutVm { public int DesignId {get;set;} [Required,MinLength(8)] public string ShippingAddress {get;set;}="";[Required,RegularExpression(@"^[0-9]{10}$")] public string Phone {get;set;}=""; }
public static class Pricing { public static decimal SizeFactor(string size)=>size switch {"Small"=>0.85m,"Large"=>1.35m,_=>1m};public static decimal UnitPrice(Product p,DesignVm v)=>Math.Round(p.BasePrice*SizeFactor(v.Size)+(string.IsNullOrWhiteSpace(v.PersonalName)?0:30)+(v.Bow?20:0)+(v.GiftWrap?35:0),2); }
