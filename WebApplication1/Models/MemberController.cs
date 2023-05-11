using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Models
{
    public class MemberController : Controller
    {
        public IActionResult MemberRegister()
        {
            return View();
        }

        //註冊作業端點-action 參數名稱 定義與表單欄位 name Attribute一致
        public IActionResult memberSave(string userName,string password,string realName,string email)
        {
            string msg = $"{userName}-{password}-{realName}-{email}";
            //回應文字 ContentResult
            return Content(msg);
        }

        //將表單欄位注入Entity物件
        //Members 物件直接產生注入近來
        //這個端點只限制採用POST傳送方法
        //使用Candy Syntax(語法糖)
        [HttpPostAttribute]//Attribute可省略
        public IActionResult memberSaveEntity(Models.Members members)
        {
            //回應文字 ContentResult
            return Content(members.realName);
        }
    }
}
