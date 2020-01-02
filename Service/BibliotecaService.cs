using System;
using System.Collections.Generic;
using Biblio;
using System.ServiceModel;
using Service.Dto;
using AutoMapper;

namespace Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class BibliotecaService : IBiblioteca
    {
        private AchizitieCarte _achizitieCarteService;
        private ImprumutareCarte _imprumutareCarteService;
        private RestituireCarte _restituireCarteService;
        private Statistici _statisticiService;

        MapperConfiguration config = new MapperConfiguration(cfg => {
            cfg.CreateMap<Gen, GenDto>();
            cfg.CreateMap<Autor, AutorDto>();
            cfg.CreateMap<Carte, CarteDto>();
            cfg.CreateMap<Cititor, CititorDto>();
            cfg.CreateMap<Imprumut, ImprumutDto>();
            cfg.CreateMap<Review, ReviewDto>();
            cfg.CreateMap<GenDto, Gen>();
            cfg.CreateMap<AutorDto, Autor>();
            cfg.CreateMap<CarteDto, Carte>();
            cfg.CreateMap<CititorDto, Cititor>();
            cfg.CreateMap<ImprumutDto, Imprumut>();
            cfg.CreateMap<ReviewDto, Review>();
        });

        IMainWindow mHwnd;
        public BibliotecaService()
        {
            _achizitieCarteService = new AchizitieCarte();
            _imprumutareCarteService = new ImprumutareCarte();
            _restituireCarteService = new RestituireCarte();
            _statisticiService = new Statistici();
        }
        
        public void PassMainWindow(IMainWindow mw)
        {
            mHwnd = mw;
        }

        public void achizitie(string titluCarte, string descrieGen, string numeAutor, string prenumeAutor, int numar_de_inserari)
        {
            _achizitieCarteService.achizitie(titluCarte, descrieGen, numeAutor, prenumeAutor, numar_de_inserari);
        }

        public bool existaCititor(string numeCititor, string prenumeCititor, string adresaCititor, string emailCititior)
        {
            return _imprumutareCarteService.existaCititor(numeCititor, prenumeCititor, adresaCititor, emailCititior);
        }

        public List<GenDto> getAllGens()
        {

            IMapper mapper = config.CreateMapper();
            var list  = _imprumutareCarteService.getAllGens();
            List<GenDto> dtoList = new List<GenDto>();
            foreach (var gen in list)
            {
                var genDto = mapper.Map<Gen, GenDto>(gen);
                dtoList.Add(genDto);
            }
            return dtoList;
        }

        public List<AutorDto> getAutoriCautati()
        {
            IMapper mapper = config.CreateMapper();
            var list = _statisticiService.getAutoriCautati();
            List<AutorDto> dtoList = new List<AutorDto>();
            foreach (var autor in list)
            {
                var autorDto = mapper.Map<Autor, AutorDto>(autor);
                dtoList.Add(autorDto);
            }
            return dtoList;
        }

        public int getAutorIdByName(string nume, string prenume)
        {         
            return _achizitieCarteService.getAutorIdByName(nume, prenume);
        }

        public CarteDto getCarteByName(string numeCarte)
        {
            IMapper mapper = config.CreateMapper();
            return mapper.Map<Carte, CarteDto>(_statisticiService.getCarteByName(numeCarte));
        }

        public List<CarteDto> getCartiDupaGen(int idGen)
        {
            IMapper mapper = config.CreateMapper();
            var list = _imprumutareCarteService.getCartiDupaGen(idGen);
            List<CarteDto> dtoList = new List<CarteDto>();
            foreach (var carte in list)
            {
                var carteDto = mapper.Map<Carte, CarteDto>(carte);
                dtoList.Add(carteDto);
            }
            return dtoList;
        }

        public List<CarteDto> getCartiSolicitate()
        {
            IMapper mapper = config.CreateMapper();
            var list = _statisticiService.getCartiSolicitate();
            List<CarteDto> dtoList = mapper.Map<List<CarteDto>>(list);
            return dtoList;
        }

        public int getCititorId(string numeCititor, string prenumeCititor, string adresaCititor, string emailCititior)
        {
            return _imprumutareCarteService.getCititorId(numeCititor, prenumeCititor, adresaCititor, emailCititior);
        }

        public List<CititorDto> getCititoriPerioada(DateTime startDate, DateTime endDate)
        {
            IMapper mapper = config.CreateMapper();
            var list = _statisticiService.getCititoriPerioada(startDate, endDate);
            List<CititorDto> dtoList = new List<CititorDto>();
            foreach (var cititor in list)
            {
                var cititorDto = mapper.Map<Cititor, CititorDto>(cititor);
                dtoList.Add(cititorDto);
            }
            return dtoList;
        }

        public int getGenIdByName(string descriere)
        {
            return _achizitieCarteService.getGenIdByName(descriere);
        }

        public List<GenDto> getGenuriCautate()
        {
            IMapper mapper = config.CreateMapper();
            var list = _statisticiService.getGenuriCautate();
            List<GenDto> dtoList = new List<GenDto>();
            foreach (var gen in list)
            {
                var genDto = mapper.Map<Gen, GenDto>(gen);
                dtoList.Add(genDto);
            }
            return dtoList;
        }

        public List<ReviewDto> getReviews(CarteDto carte)
        {
            IMapper mapper = config.CreateMapper();
            var list = _statisticiService.getReviews(mapper.Map<CarteDto, Carte>(carte));
            List<ReviewDto> dtoList = new List<ReviewDto>();
            foreach (var review in list)
            {
                var reviewDto = mapper.Map<Review, ReviewDto>(review);
                dtoList.Add(reviewDto);
            }
            return dtoList;
        }

        public short getStare(int cititorId)
        {
            return _imprumutareCarteService.getStare(cititorId);
        }

        public short getStareCititor(string numeCititor, string prenumeCititor, string adresaCititor, string emailCititior)
        {
            return _imprumutareCarteService.getStareCititor(numeCititor, prenumeCititor, adresaCititor, emailCititior);
        }

        public string getGenCarteDescriere(int genId)
        {
            return _imprumutareCarteService.getGenCarteDescriere(genId);
        }

        public int realizareImprumut(string genCarte, string titluCarte, string numeCititor, string prenumeCititor, string adresaCititor, string emailCititior)
        {
            return _imprumutareCarteService.realizareImprumut(genCarte, titluCarte, numeCititor, prenumeCititor, adresaCititor, emailCititior);
        }

        public void restituire(string numeCarte, string numeAutor, string prenumeAutor, string numeCititor, string prenumeCititor, string textReview)
        {
            _restituireCarteService.restituire(numeCarte, numeAutor, prenumeAutor, numeCititor, prenumeCititor, textReview);
        }

        public CititorDto GetCititorById(int idCititor)
        {
            IMapper mapper = config.CreateMapper();
            return mapper.Map<Cititor, CititorDto>(_imprumutareCarteService.GetCititorById(idCititor));
        }

        public string getTitluCarteById(int idCarte)
        {
            return _imprumutareCarteService.getTitluCarteById(idCarte);
        }

        public int getGenIdByCarteId(int carteId)
        {
            return _imprumutareCarteService.getGenIdByCarteId(carteId);
        }
    }
}
