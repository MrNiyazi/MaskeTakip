using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	//Çıplak Class kalmasın 
	public class PersonManager : IApplicantService
	{
		//encapsulation miras alarak yenilik veya değişiklik olduğunda hata alınmasını engeller
		public void ApplyForMask(Person person)
		{

		}

		public List<Person> GetList()
		{
			return null;
		}


		public  bool CheckPerson(Person person)
		{
			//mernis kontrolü yapılacak
			KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
			return client.TCKimlikNoDogrulaAsync(
				new TCKimlikNoDogrulaRequest
				(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity,Ad:person.FirstName,Soyad:person.LastName,DogumYili:person.DateOfBirthYear)))
				.Result.Body.TCKimlikNoDogrulaResult;
		}
	}

}
