using _10dars.Api.Models;

namespace _10dars.Api.Services;

public class PassportService
{
    private List<Passport> passports;

    public PassportService()
    {
        passports = new List<Passport>();
        DataSeed();
    }

    public Passport AddPassport(Passport passport)
    {
        passport.Id = Guid.NewGuid();
        passports.Add(passport);

        return passport;
    }

    public Passport GetById(Guid id)
    {
        foreach (var passport in passports)
        {
            if (passport.Id == id)
            {
                return passport;
            }
        }

        return null;
    }

    public bool DeletePassport(Guid id)
    {
        var passportFromDb = GetById(id);
        if (passportFromDb is null)
        {
            return false;
        }

        passports.Remove(passportFromDb);
        return true;
    }

    public bool UpdatePassport(Passport passport)
    {
        var passportFromDb = GetById(passport.Id);
        if (passportFromDb is null)
        {
            return false;
        }

        var index = passports.IndexOf(passport);
        passports[index] = passport;
        return true;
    }

    public bool ConnecToPerson(Guid personId, Guid passportId)
    {
        var passportFromDb = GetById(passportId);

        if (passportFromDb is null)
        {
            return false;
        }

        var index = passports.IndexOf(passportFromDb);
        passports[index].PersonId = personId;
        return true;
    }

    public List<Passport> GetPassports()
    {
        return passports;
    }

    public void DataSeed()
    {
        passports.Add(new Passport()
        {
            Id = Guid.NewGuid(),
            Serie = "AD4122336",
            Country = "UZB",
            GivenDate = DateTime.Now,
        });
    }
}
