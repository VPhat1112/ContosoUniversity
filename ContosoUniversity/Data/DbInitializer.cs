using ContosoUniversity.Models;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            // Look for any students.
            if (context.congNhans.Any())
            {
                return;   // DB has been seeded
            }

            var congnhans = new CongNhan[]
            {
                new CongNhan {FirstMidName="Carson",LastName="Alexander",BirthDay=DateTime.Parse("2019-09-01")},
                new CongNhan {FirstMidName="Meredith",LastName="Alonso",BirthDay=DateTime.Parse("2017-09-01")},
                new CongNhan {FirstMidName="Arturo",LastName="Anand",BirthDay=DateTime.Parse("2019-09-01")},
                new CongNhan {FirstMidName="Gytis",LastName="Barzdukas",BirthDay=DateTime.Parse("2018-09-01")},
                new CongNhan {FirstMidName="Yan",LastName="Li",BirthDay=DateTime.Parse("2019-09-01")},
                new CongNhan {FirstMidName="Laura",LastName="Norman",BirthDay=DateTime.Parse("2019-09-01")},
                
            };

            context.congNhans.AddRange(congnhans);
            context.SaveChanges();

            var calams = new Calam[]
            {
                new Calam{Title="Chemistry",Credits=3},
                new Calam{Title="Chemistry",Credits=3},
                new Calam{Title="Microeconomics",Credits=3},
                new Calam{Title="Macroeconomics",Credits=3},
                new Calam{Title="Calculus",Credits=4},
                new Calam{Title="Trigonometry",Credits=4},
                new Calam{Title="Composition",Credits=3},
                new Calam{Title="Literature",Credits=4}
            };

            context.calams.AddRange(calams);
            context.SaveChanges();

            var Bangdangkies = new BangDangKy[]
            {
                new BangDangKy{IDCongNhan=1,IdCalam=1050,kind=Kind.Sang},
                new BangDangKy{IDCongNhan=1,IdCalam=4022,kind=Kind.Chieu},
                new BangDangKy{IDCongNhan=1,IdCalam=4041,kind=Kind.Sang},
                new BangDangKy{IDCongNhan=2,IdCalam=1045,kind=Kind.Sang},
                new BangDangKy{IDCongNhan=2,IdCalam=3141,kind=Kind.Chieu},
                new BangDangKy{IDCongNhan=2,IdCalam=2021,kind=Kind.Chieu},
                new BangDangKy{IDCongNhan=3,IdCalam=1050},
                new BangDangKy{IDCongNhan=4,IdCalam=1050},
                new BangDangKy{IDCongNhan=4,IdCalam=4022,kind=Kind.Sang},
                new BangDangKy{IDCongNhan=5,IdCalam=4041,kind=Kind.Chieu},
                new BangDangKy{IDCongNhan=6,IdCalam=1045},
                new BangDangKy{IDCongNhan=7,IdCalam=3141,kind=Kind.Sang},
            };

            context.BangDangKies.AddRange(Bangdangkies);
            context.SaveChanges();
        }
    }
}