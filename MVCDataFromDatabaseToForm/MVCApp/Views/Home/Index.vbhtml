@Code
    ViewData("Title") = "Home Page"
End Code

<div align="center" class="jumbotron">
    <h1>Ajudas de Custo</h1>
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

                <span>
                    <br><b>Dados do Serviço</b> <br><br>
                </span>

                <label for="local-servico">Local do Serviço:</label>
                <div>
                    <input id="local-servico" type="text" name="local-servico" size="35">
                    <span></span>
                </div>

                <label for="dia-servico"><br>Dia em que o serviço foi prestado:</label>
                <div>
                    <input id="dia-servico" type="text" name="dia-servico" placeholder="DD/MM/AA" align="center">
                    <span></span>
                </div>

                <label for="horas-entrada"><br>Horas de entrada:</label>
                <div>
                    <input id="horas-entrada" type="text" name="horas-entrada" placeholder="HH:MM">
                    <span></span>
                </div>

                <label for="horas-saida"><br>Horas de Saída:</label>
                <div>
                    <input id="horas-saida" type="text" name="horas-saida" placeholder="HH:MM">
                    <span></span>
                </div>

                <label for="percentagem"><br>Percentagem:</label>
                <div>
                    <input id="percentagem" type="text" name="percentagem">
                    <span></span>
                </div>

                <label for="valor"><br>Valor:</label>
                <div>
                    <input id="valor" ype="text" name="valor">
                    <span></span>
                </div>


                <p> <br> Assinatura: <br> _________________________________________________</p>

                <a href="@Url.Action("ExportAjudas")">Exportar para PDF</a>
            </form>
        </div>
    </div>
</div>