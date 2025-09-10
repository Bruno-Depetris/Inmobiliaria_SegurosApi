namespace Inmobiliaria_SegurosApi.Interfaces.Common {
    public interface IUnitOfWork : IDisposable {
        // Repositories
        IBarrioRepository BarrioRepository { get; }
        ICanales_NotifRepository Canales_NotifRepository { get; }
        ICiudadeRepository CiudadeRepository { get; }
        IClienteRepository ClienteRepository { get; }
        IComisioneRepository ComisioneRepository { get; }
        IContratoRepository ContratoRepository { get; }
        IEstados_CivilRepository Estados_CivilRepository { get; }
        IFotos_PropiedadeRepository Fotos_PropiedadeRepository { get; }
        IInteresadoRepository InteresadoRepository { get; }
        ILog_ActividadeRepository Log_ActividadeRepository { get; }
        IMonedaRepository MonedaRepository { get; }
        INotificacioneRepository NotificacioneRepository { get; }
        IPagoRepository PagoRepository { get; }
        IPersonaRepository PersonaRepository { get; }
        IProductoreRepository ProductoreRepository { get; }
        IPropiedadeRepository PropiedadeRepository { get; }
        ISeguroRepository SeguroRepository { get; }
        IUsuarioRepository UsuarioRepository { get; }
        IVariables_ImpositivaRepository Variables_ImpositivaRepository { get; }

        Task<int> SaveChangesAsync();
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollbackTransactionAsync();
    }
}
