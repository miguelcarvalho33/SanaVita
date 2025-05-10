namespace SanaVitaAPI.Services
{
    public class FallbackState
    {
        private bool _isInFallback = false;
        private DateTime? _activatedAt = null;

        public bool IsFallbackEnabled => _isInFallback;

        public void Activate()
        {
            _isInFallback = true;
            _activatedAt = DateTime.UtcNow;
        }

        public void Deactivate()
        {
            _isInFallback = false;
            _activatedAt = null;
        }

        public string Status()
        {
            return _isInFallback
                ? $"Modo degradado ATIVO desde {_activatedAt?.ToString("u")}."
                : "Sistema operacional normal.";
        }
    }
}
