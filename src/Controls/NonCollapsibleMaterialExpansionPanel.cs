using ReaLTaiizor.Controls;
using System.ComponentModel;

namespace GestionAgraria.Controls
{
    /// <summary>
    /// Versión personalizada de MaterialExpansionPanel que deshabilita completamente
    /// la funcionalidad de colapsar/expandir, incluso al hacer clic en la cabecera.
    /// </summary>
    public class NonCollapsibleMaterialExpansionPanel : MaterialExpansionPanel
    {
        public NonCollapsibleMaterialExpansionPanel()
        {
            // Asegurar que el botón de colapsar esté oculto
            this.ShowCollapseExpand = false;
        }

        /// <summary>
        /// Sobrescribe el método OnMouseDown para evitar que el clic
        /// en la cabecera colapse/expanda el panel
        /// </summary>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            // No llamar a base.OnMouseDown(e) para evitar el comportamiento de colapso
            // Solo procesar otros eventos de mouse sin el comportamiento de expansión/colapso
        }

        /// <summary>
        /// Sobrescribe el método OnClick para deshabilitar el colapso por click
        /// </summary>
        protected override void OnClick(EventArgs e)
        {
            // No llamar a base.OnClick(e) para evitar el comportamiento de colapso
        }

        /// <summary>
        /// Asegurar que el panel siempre esté expandido
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool Collapse
        {
            get => false;
            set { /* No hacer nada, siempre expandido */ }
        }
    }
}