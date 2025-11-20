namespace Dima.Core.Enums;

//PCI -> PCI Compliance
//Stripe -> é uma gateway(intermediário) para nossa aplicacao se comunicar com a VISA 
//mecanismo que permite que um cliente pague por um produto ou serviço em um site usando cartão de crédito/débito ou outro método, de forma segura e em tempo real.
public enum EPaymentGateway
{
    Stripe = 1,
    PayPal = 2,
    PagarMe = 3
}