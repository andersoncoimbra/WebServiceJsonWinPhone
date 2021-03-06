﻿using WebServiceJsonWinPhone.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// O item de template Basic Page está documentado em http://go.microsoft.com/fwlink/?LinkID=390556

namespace WebServiceJsonWinPhone.pages
{
    /// <resumo>
    /// Uma página vazia que pode ser usada sozinha ou por meio da navegação dentro de um quadro.
    /// </resumo>
    public sealed partial class ConteinerDePaginaWeb : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        public ConteinerDePaginaWeb()
        {
            this.InitializeComponent();

            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += this.NavigationHelper_LoadState;
            this.navigationHelper.SaveState += this.NavigationHelper_SaveState;
        }

        /// <resumo>
        /// Obtém o <see cref="NavigationHelper"/> associado a esta <see cref="Page"/>.
        /// </resumo>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        /// <resumo>
        /// Obtém o modelo de exibição desta <see cref="Page"/>.
        /// Isso pode ser alterado para um modelo de exibição fortemente tipado.
        /// </resumo>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <resumo>
        /// Preenche a página com conteúdo transmitido durante a navegação.  Qualquer estado salvo também é
        /// fornecido ao recriar uma página a partir de uma sessão anterior.
        /// </summary>
        /// <param name="sender">
        /// A origem do evento; geralmente <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Dados de evento que fornecem o parâmetro de navegação passado para
        /// <see cref="Frame.Navigate(Type, Object)"/> quando esta página foi solicitada inicialmente e
        /// um dicionário de estado preservado por esta página durante uma sessão
        /// anterior.  O estado será nulo na primeira vez que uma página for visitada.</param>
        private void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <resumo>
        /// Preserva o estado associado a esta página no caso do aplicativo ser suspenso ou a
        /// página é descartada do cache de navegação.  Valores devem estar de acordo com os requisitos de
        /// serialização <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender"> A origem do evento; geralmente <see cref="NavigationHelper"/></param>
        /// <param name="e">Dados do evento que fornecem um dicionário vazio a ser preenchido com
        /// estado serializável.</param>
        private void NavigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region Registro do NavigationHelper

        /// <resumo>
        /// Os métodos fornecidos nesta seção são usados simplesmente para permitir
        /// NavigationHelper para responder aos métodos de navegação da página.
        /// <para>
        /// A lógica específica à página deve ser colocada em manipuladores de eventos para 
        /// <see cref="NavigationHelper.LoadState"/>
        /// e <see cref="NavigationHelper.SaveState"/>.
        /// O parâmetro de navegação está disponível no método LoadState 
        /// além do estado da página preservado durante uma sessão anterior.
        /// </para>
        /// </summary>
        /// <param name="e">Fornece dados dos métodos de navegação e manipuladores
        /// de eventos que não podem cancelar a solicitação de navegação.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private void webViewMtd1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PaginaWebMtd1));
        }

        private void webViewMtd2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PaginaWebMtd2));
        }
    }
}
