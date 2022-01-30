using RentACar.Dto.Dto;
using RentACar.Data.Context;
using RentACar.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace RentACar.Services.Services
{
    public interface IAracServices
    {
        List<AracDto> GetAll();
        AracDto GetById(int id);
        void Add(AracDto dto);
        void Update(AracDto dto);
        void Delete(int id);
    }
    public class AracServices : IAracServices
    {
        public void Add(AracDto dto)
        {
            using (UnitOfWorkRepositoryGeneric uow = new UnitOfWorkRepositoryGeneric())
            {
                var entity = new Arac
                {
                    Id = dto.Id,
                    Plaka = dto.Plaka,
                    Marka = dto.Marka,
                    Model = dto.Model,
                    Yil = dto.Yil,
                    Yakit = dto.Yakit,
                    Vites = dto.Vites,
                    MotorGucu = dto.MotorGucu,
                    KasaTipi = dto.KasaTipi,
                    KapiSayi = dto.KapiSayi,
                    Renk = dto.Renk,
                    AirBag = dto.AirBag,
                    Koltuk = dto.Koltuk,
                    SonKm = dto.SonKm,
                    Hasar = dto.Hasar,
                    Resim = dto.Resim
                };
                uow.GetRepository<Arac>().Add(entity);
                uow.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (UnitOfWorkRepositoryGeneric uow = new UnitOfWorkRepositoryGeneric())
            {
                var entity = uow.GetRepository<Arac>().GetById(id);
                uow.GetRepository<Arac>().Delete(entity);
                uow.SaveChanges();
            }
        }
        
        public List<AracDto> GetAll()
        {
            
            List<AracDto> result = new List<AracDto>();
            using (UnitOfWorkRepositoryGeneric uow = new UnitOfWorkRepositoryGeneric())
            {
                var list = uow.GetRepository<Arac>().GetAll().ToList();
                result = list.Select(a => new AracDto
                {
                    Id = a.Id,
                    Plaka = a.Plaka,
                    Marka = a.Marka,
                    Model = a.Model,
                    Yil = a.Yil,
                    Yakit = a.Yakit,
                    Vites = a.Vites,
                    MotorGucu = a.MotorGucu,
                    KasaTipi = a.KasaTipi,
                    KapiSayi = a.KapiSayi,
                    Renk = a.Renk,
                    AirBag = a.AirBag,
                    Koltuk = a.Koltuk,
                    SonKm = a.SonKm,
                    Hasar = a.Hasar,
                    Resim = a.Resim
                }).ToList();
            }
            return result;
        }

        public AracDto GetById(int id)
        {
            AracDto result = new AracDto();
            using (UnitOfWorkRepositoryGeneric uow = new UnitOfWorkRepositoryGeneric())
            {
                var entity = uow.GetRepository<Arac>().GetById(id);
                result = new AracDto
                {
                    Id = entity.Id,
                    Plaka = entity.Plaka,
                    Marka = entity.Marka,
                    Model = entity.Model,
                    Yil = entity.Yil,
                    Yakit = entity.Yakit,
                    Vites = entity.Vites,
                    MotorGucu = entity.MotorGucu,
                    KasaTipi = entity.KasaTipi,
                    KapiSayi = entity.KapiSayi,
                    Renk = entity.Renk,
                    AirBag = entity.AirBag,
                    Koltuk = entity.Koltuk,
                    SonKm = entity.SonKm,
                    Hasar = entity.Hasar,
                    Resim = entity.Resim
                };
            }
            return result;
        }

        public void Update(AracDto dto)
        {
            using (UnitOfWorkRepositoryGeneric uow = new UnitOfWorkRepositoryGeneric())
            {
                var entity = uow.GetRepository<Arac>().GetById(dto.Id);

                entity.Id = dto.Id;
                entity.Plaka = dto.Plaka;
                entity.Marka = dto.Marka;
                entity.Model = dto.Model;
                entity.Yil = dto.Yil;
                entity.Yakit = dto.Yakit;
                entity.Vites = dto.Vites;
                entity.MotorGucu = dto.MotorGucu;
                entity.KasaTipi = dto.KasaTipi;
                entity.KapiSayi = dto.KapiSayi;
                entity.Renk = dto.Renk;
                entity.AirBag = dto.AirBag;
                entity.Koltuk = dto.Koltuk;
                entity.SonKm = dto.SonKm;
                entity.Hasar = dto.Hasar;
                entity.Resim = dto.Resim;

                uow.GetRepository<Arac>().Update(entity);
                uow.SaveChanges();
                
            }
        }
    }
}
