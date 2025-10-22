using ReaLTaiizor.Controls;
using System.ComponentModel;

namespace GestionAgraria.Controls
{
    /// <summary>
    /// Versi�n personalizada de MaterialExpansionPanel que deshabilita completamente
    /// la funcionalidad de colapsar/expandir, incluso al hacer clic en la cabecera
    /// y al presionar los botones Save/Cancel.
    /// </summary>
    public class NonCollapsibleMaterialExpansionPanel : MaterialExpansionPanel
    {
        private bool _suppressCollapseToggle = false;

        public NonCollapsibleMaterialExpansionPanel()
        {
            // Asegurar que el bot�n de colapsar est� oculto
            this.ShowCollapseExpand = false;
            
            // Suscribirse a los eventos para interceptarlos
            this.SaveClick += OnInternalSaveClick;
            this.CancelClick += OnInternalCancelClick;
        }

        /// <summary>
        /// Intercepta el evento SaveClick para evitar el colapso autom�tico
        /// </summary>
        private void OnInternalSaveClick(object? sender, EventArgs e)
        {
            // Marcar que se debe suprimir el colapso
            _suppressCollapseToggle = true;
        }

        /// <summary>
        /// Intercepta el evento CancelClick para evitar el colapso autom�tico
        /// </summary>
        private void OnInternalCancelClick(object? sender, EventArgs e)
        {
            // Marcar que se debe suprimir el colapso
            _suppressCollapseToggle = true;
        }

        /// <summary>
        /// Sobrescribe el m�todo OnMouseDown para evitar que el clic
        /// en la cabecera colapse/expanda el panel
        /// </summary>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            // No llamar a base.OnMouseDown(e) para evitar el comportamiento de colapso
            // Solo procesar otros eventos de mouse sin el comportamiento de expansi�n/colapso
        }

        /// <summary>
        /// Sobrescribe el m�todo OnClick para deshabilitar el colapso por click
        /// </summary>
        protected override void OnClick(EventArgs e)
        {
            // No llamar a base.OnClick(e) para evitar el comportamiento de colapso
        }

        /// <summary>
        /// Asegurar que el panel siempre est� expandido
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool Collapse
        {
            get => false;
            set 
            { 
                // Si se est� intentando colapsar y debemos suprimirlo, no hacer nada
                if (_suppressCollapseToggle)
                {
                    _suppressCollapseToggle = false; // Resetear la bandera
                    return; // No permitir el colapso
                }
                // No hacer nada en cualquier caso, siempre expandido
            }
        }

        /// <summary>
        /// Sobrescribe la propiedad Height para evitar cambios de tama�o durante colapso
        /// </summary>
        protected override void OnLayout(LayoutEventArgs e)
        {
            // Guardar el estado de expansi�n antes de llamar al base
            var wasCollapsed = base.Collapse;
            
            base.OnLayout(e);
            
            // Forzar que siempre est� expandido despu�s del layout
            if (base.Collapse != false)
            {
                base.Collapse = false;
            }
        }
    }
}