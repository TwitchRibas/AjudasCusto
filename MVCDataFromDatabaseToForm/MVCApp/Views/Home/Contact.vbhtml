@Code
    ViewData("Title") = "Contact"
End Code

    <div align="center" class="jumbotron">
        <h1>Cálculo de Deslocação em Viatura Própria</h1>
        <div id="Home">
            <div>
                <form>
                    <span>
                        <b>Dados do Empregado</b> <br><br>
                    </span>

                    <label for="nome">Nome do Empregado:</label>
                    <div>
                        <input id="nome" type="text" name="nome" size="35">
                        <span></span>
                    </div>

                    <label for="email"><br>Número de Contribuinte:</label>
                    <div>
                        <input id="numcontribuinte" type="text" name="numcontribuinte" size="35">
                        <span></span>
                    </div>

                    <label for="contacto"><br> Contacto:</label>
                    <div>
                        <input id="contacto" type="text" name="contacto" size="35">
                        <span></span>
                    </div>

                    <label for="contacto"><br> Morada:</label>
                    <div>
                        <input id="contacto" type="text" name="contacto" size="35">
                        <span></span>
                    </div>

                    <label for="contacto"><br> Viatura:</label>
                    <div>
                        <input id="contacto" type="text" name="contacto" size="35">
                        <span></span>
                    </div>

                    <span>
                        <br><b>Dados de Deslocação</b> <br><br>
                    </span>

                    <label for="local-servico">Local de  Origem</label>
                    <div>
                        <input id="local-servico" type="text" name="local-servico" size="35">
                        <span></span>
                    </div>

                    <label for="local-servico"><br>Local de  Destino:</label>
                    <div>
                        <input id="local-servico" type="text" name="local-servico" size="35">
                        <span></span>
                    </div>

                    <label for="dia-servico"><br>Justificação:</label>
                    <div>
                        <input id="dia-servico" type="text" name="dia-servico" size="35">
                        <span></span>
                    </div>

                    <label for="horas-saida"><br>Data da Desloçação:</label>
                    <div>
                        <input id="horas-saida" type="text" name="horas-saida" placeholder="HH:MM">
                        <span></span>
                    </div>

                    <label for="horas-entrada"><br>Número Total de Quilómetros:</label>
                    <div>
                        <input id="horas-entrada" type="text" name="horas-entrada">
                        <span></span>
                    </div>

                    <label for="horas-saida"><br>Valor Recebido:</label>
                    <div>
                        <input id="horas-saida" type="text" name="horas-saida">
                        <span></span>
                    </div>

                    <p> <br> Assinatura: <br> _________________________________________________</p>

                    <a href="@Url.Action("ExportAjudas")">Exportar para PDF</a>
                </form>
            </div>
        </div>
    </div>