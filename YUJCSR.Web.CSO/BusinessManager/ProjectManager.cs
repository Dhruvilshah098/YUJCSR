using Newtonsoft.Json;
using System.Net.Http.Headers;
using YUJCSR.Web.CSO.Models;
using YUJCSR.Web.Project.Models;

namespace YUJCSR.Web.CSO.BusinessManager
{
    public class ProjectManager
    {
        private string _baseurl;
        private IConfiguration _configuration;
        public ProjectManager(IConfiguration iConfig)
        {
            _configuration = iConfig;
            _baseurl = _configuration.GetValue<string>("BaseUrl");
        }

        public List<MilestoneModel> GetMilestones(string projectId)
        {
            List<MilestoneModel> lstModel = new List<MilestoneModel>();

            try
            {
                using (var client = new HttpClient())
                {

                    client.BaseAddress = new Uri(_baseurl);
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var getData = client.GetAsync("Project/" + projectId + "/milestones");
                    getData.Wait();
                    var Res = getData.Result;
                    if (Res.IsSuccessStatusCode)
                    {
                        var data = JsonConvert.DeserializeObject<ResultMilestone>(Res.Content.ReadAsStringAsync().Result);
                        return data.result;
                    }
                }
                return lstModel;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<BudgetModel> GetBudgets(string projectId)
        {
            List<BudgetModel> lstModel = new List<BudgetModel>();

            try
            {
                using (var client = new HttpClient())
                {

                    client.BaseAddress = new Uri(_baseurl);
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var getData = client.GetAsync("Project/"+ projectId + "/budgets");
                    getData.Wait();
                    var Res = getData.Result;
                    if (Res.IsSuccessStatusCode)
                    {
						ResultBudget objResultBudget = JsonConvert.DeserializeObject<ResultBudget> (Res.Content.ReadAsStringAsync().Result);
                        return objResultBudget.result;

                    }
                }
                return lstModel;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<ProjectModel> GetProjects()
        {
            List<ProjectModel> lstModel = new List<ProjectModel>();

            try
            {
                using (var client = new HttpClient())
                {
                   
                    client.BaseAddress = new Uri(_baseurl);
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var getData  = client.GetAsync("Project");
                    getData.Wait();
                    var Res = getData.Result;
                    if (Res.IsSuccessStatusCode)
                    {
                        lstModel =  JsonConvert.DeserializeObject<List<ProjectModel>>(Res.Content.ReadAsStringAsync().Result);
                        return lstModel;
                    }
                }
                return lstModel;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
