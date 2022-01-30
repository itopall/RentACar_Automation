using RentACar.Data.Context;
using RentACar.Data.UnitOfWork;
using RentACar.Dto.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Services.Services
{
    public interface ISatisServices
    {
        List<SatisDto> GetAll();
        SatisDto GetById(int id);
        void Add(SatisDto dto, MusteriDto musteriDto, AracDto aracDto, UserDto userDto,KiraDto kiraDto, RezervasyonDto rezervasyonDto);
        void Update(SatisDto dto, MusteriDto musteriDto, AracDto aracDto, UserDto userDto, KiraDto kiraDto, RezervasyonDto rezervasyonDto);
        void Delete(int id);

        
    }
    public class SatisServices : ISatisServices
    {
        public void Add(SatisDto dto, MusteriDto musteriDto, AracDto aracDto, UserDto userDto,KiraDto kiraDto,RezervasyonDto rezervasyonDto)
        {
            using (UnitOfWorkRepositoryGeneric uow = new UnitOfWorkRepositoryGeneric())
            {
                var entity = new Sati
                {
                    Id = dto.Id,
                    MusteriId = musteriDto.Id,
                    AracId = aracDto.Id,
                    KiraId = dto.KiraId,
                    RezervasyonId = dto.RezervasyonId,
                    UserId = userDto.Id,
                    CreatedBy = dto.CreatedBy,
                    CreatedDate = dto.CreatedDate,
                    IsActive = dto.IsActive
                };
                uow.GetRepository<Sati>().Add(entity);
                uow.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using (UnitOfWorkRepositoryGeneric uow = new UnitOfWorkRepositoryGeneric())
            {
                var entity = uow.GetRepository<Sati>().GetById(id);
                uow.GetRepository<Sati>().Delete(entity);
                uow.SaveChanges();
            }
        }

        public List<SatisDto> GetAll()
        {

            List<SatisDto> result = new List<SatisDto>();
            using (UnitOfWorkRepositoryGeneric uow = new UnitOfWorkRepositoryGeneric())
            {
                var list = uow.GetRepository<Sati>().GetAll().ToList();
                result = list.Select(a => new SatisDto
                {
                    Id = a.Id,
                    MusteriId = a.MusteriId,
                    MusteriAdi = a.Musteri.Adi,
                    AracPlaka = a.Arac.Plaka,
                    userName = a.User.AdSoyad,
                    AracId = a.AracId,
                    RezervasyonId = a.RezervasyonId,
                    KiraId = a.KiraId,
                    UserId = a.UserId,
                    CreatedBy = a.CreatedBy,
                    CreatedDate = a.CreatedDate,
                    UpdateBy = a.UpdateBy,
                    UpdateDate = a.UpdateDate,
                    IsActive = a.IsActive
                }).ToList();
            }
            return result;
        }

        public SatisDto GetById(int id)
        {
            SatisDto result = new SatisDto();
            using (UnitOfWorkRepositoryGeneric uow = new UnitOfWorkRepositoryGeneric())
            {
                var entity = uow.GetRepository<Sati>().GetById(id);
                result = new SatisDto
                {
                    Id = entity.Id,
                    MusteriId = entity.MusteriId,
                    AracId = entity.AracId,
                    KiraId = entity.KiraId,
                    RezervasyonId = entity.RezervasyonId,
                    UserId = entity.UserId,
                    CreatedBy = entity.CreatedBy,
                    CreatedDate = entity.CreatedDate,
                    UpdateBy = entity.UpdateBy,
                    UpdateDate = entity.UpdateDate,
                    IsActive = entity.IsActive
                };
            }
            return result;
        }


        public void Update(SatisDto dto, MusteriDto musteriDto, AracDto aracDto, UserDto userDto, KiraDto kiraDto, RezervasyonDto rezervasyonDto)
        {
            using (UnitOfWorkRepositoryGeneric uow = new UnitOfWorkRepositoryGeneric())
            {
                var entity = uow.GetRepository<Sati>().GetById(dto.Id);

                entity.Id = dto.Id;
                entity.MusteriId = musteriDto.Id;
                entity.Musteri.Adi = musteriDto.Adi;
                entity.AracId = aracDto.Id;
                entity.Arac.Plaka = aracDto.Plaka;
                entity.KiraId = kiraDto.Id;
                entity.RezervasyonId = rezervasyonDto.Id;
                entity.UserId = userDto.Id;
                entity.User.AdSoyad = userDto.AdSoyad;
                entity.UpdateBy = dto.UpdateBy;
                entity.UpdateDate = dto.UpdateDate;
                entity.IsActive = dto.IsActive;



                uow.GetRepository<Sati>().Update(entity);
                uow.SaveChanges();

            }
        }
    }
}
