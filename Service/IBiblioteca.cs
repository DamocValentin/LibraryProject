using System;
using System.Collections.Generic;
using System.ServiceModel;
using Service.Dto;

namespace Service
{
    [ServiceContract]
    public interface IBiblioteca
    {
        [OperationContract]
        void achizitie(string titluCarte, string descrieGen, string numeAutor, string prenumeAutor, int numar_de_inserari);

        [OperationContract]
        int realizareImprumut(string genCarte, string titluCarte, string numeCititor, string prenumeCititor, string adresaCititor, string emailCititior);

        [OperationContract]
        void restituire(string numeCarte, string numeAutor, string prenumeAutor, string numeCititor, string prenumeCititor, string textReview);

        [OperationContract]
        List<CititorDto> getCititoriPerioada(DateTime startDate, DateTime endDate);

        [OperationContract]
        List<CarteDto> getCartiSolicitate();

        [OperationContract]
        List<AutorDto> getAutoriCautati();

        [OperationContract]
        List<GenDto> getGenuriCautate();

        [OperationContract]
        List<ReviewDto> getReviews(CarteDto carte);

        [OperationContract]
        List<GenDto> getAllGens();

        [OperationContract]
        bool existaCititor(string numeCititor, string prenumeCititor, string adresaCititor, string emailCititior);

        [OperationContract]
        int getCititorId(string numeCititor, string prenumeCititor, string adresaCititor, string emailCititior);

        [OperationContract]
        List<CarteDto> getCartiDupaGen(int idGen);

        [OperationContract]
        Int16 getStare(int cititorId);

        [OperationContract]
        int getAutorIdByName(string nume, string prenume);

        [OperationContract]
        int getGenIdByName(string descriere);

        [OperationContract]
        short getStareCititor(string numeCititor, string prenumeCititor, string adresaCititor, string emailCititior);

        [OperationContract]
        string getGenCarteDescriere(int genId);

        [OperationContract]
        CarteDto getCarteByName(string numeCarte);

        [OperationContract]
        string getTitluCarteById(int idCarte);

        [OperationContract]
        CititorDto GetCititorById(int idCititor);

        [OperationContract]
        int getGenIdByCarteId(int carteId);
    }
}
