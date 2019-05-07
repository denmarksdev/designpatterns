using Pattern.Domain.Interfaces;
using System;

namespace Pattern.Domain.Domains.FanDomain
{
    public class Fan : IFan
    {
        public void Atualiza(ICelebridade celebridade)
        {
             Console.WriteLine($"Fan notificado. Tweer de {celebridade.Nome}:{celebridade.Tweet}");
        }
    }
}
