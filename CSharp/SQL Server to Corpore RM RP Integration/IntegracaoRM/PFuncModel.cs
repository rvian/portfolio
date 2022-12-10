using System.Xml.Serialization;
namespace IntegracaoRM
{
    [XmlRoot(ElementName = "PFunc")]
    public class PFunc
    {
        [XmlElement(ElementName = "CODCOLIGADA")]
        public string CODCOLIGADA { get; set; }
        [XmlElement(ElementName = "CHAPA")]
        public string CHAPA { get; set; }
        [XmlElement(ElementName = "NROFICHAREG")]
        public string NROFICHAREG { get; set; }
        [XmlElement(ElementName = "CODRECEBIMENTO")]
        public string CODRECEBIMENTO { get; set; }
        [XmlElement(ElementName = "CODSITUACAO")]
        public string CODSITUACAO { get; set; }
        [XmlElement(ElementName = "CODTIPO")]
        public string CODTIPO { get; set; }
        [XmlElement(ElementName = "CODSECAO")]
        public string CODSECAO { get; set; }
        [XmlElement(ElementName = "CODFUNCAO")]
        public string CODFUNCAO { get; set; }
        [XmlElement(ElementName = "CODSINDICATO")]
        public string CODSINDICATO { get; set; }
        [XmlElement(ElementName = "JORNADA")]
        public string JORNADA { get; set; }
        [XmlElement(ElementName = "CODHORARIO")]
        public string CODHORARIO { get; set; }
        [XmlElement(ElementName = "NRODEPIRRF")]
        public string NRODEPIRRF { get; set; }
        [XmlElement(ElementName = "NRODEPSALFAM")]
        public string NRODEPSALFAM { get; set; }
        [XmlElement(ElementName = "DTBASE")]
        public string DTBASE { get; set; }
        [XmlElement(ElementName = "SALARIO")]
        public string SALARIO { get; set; }
        [XmlElement(ElementName = "SITUACAOFGTS")]
        public string SITUACAOFGTS { get; set; }
        [XmlElement(ElementName = "DTOPCAOFGTS")]
        public string DTOPCAOFGTS { get; set; }
        [XmlElement(ElementName = "CONTAFGTS")]
        public string CONTAFGTS { get; set; }
        [XmlElement(ElementName = "SALDOFGTS")]
        public string SALDOFGTS { get; set; }
        [XmlElement(ElementName = "DTSALDOFGTS")]
        public string DTSALDOFGTS { get; set; }
        [XmlElement(ElementName = "CONTRIBSINDICAL")]
        public string CONTRIBSINDICAL { get; set; }
        [XmlElement(ElementName = "APOSENTADO")]
        public string APOSENTADO { get; set; }
        [XmlElement(ElementName = "TEMMAIS65ANOS")]
        public string TEMMAIS65ANOS { get; set; }
        [XmlElement(ElementName = "AJUDACUSTO")]
        public string AJUDACUSTO { get; set; }
        [XmlElement(ElementName = "PERCENTADIANT")]
        public string PERCENTADIANT { get; set; }
        [XmlElement(ElementName = "ARREDONDAMENTO")]
        public string ARREDONDAMENTO { get; set; }
        [XmlElement(ElementName = "DATAADMISSAO")]
        public string DATAADMISSAO { get; set; }
        [XmlElement(ElementName = "TIPOADMISSAO")]
        public string TIPOADMISSAO { get; set; }
        [XmlElement(ElementName = "MOTIVOADMISSAO")]
        public string MOTIVOADMISSAO { get; set; }
        [XmlElement(ElementName = "TEMPRAZOCONTR")]
        public string TEMPRAZOCONTR { get; set; }
        [XmlElement(ElementName = "DTVENCFERIAS")]
        public string DTVENCFERIAS { get; set; }
        [XmlElement(ElementName = "QUERABONO")]
        public string QUERABONO { get; set; }
        [XmlElement(ElementName = "QUER1APARC13O")]
        public string QUER1APARC13O { get; set; }
        [XmlElement(ElementName = "NRODIASADIANTFER")]
        public string NRODIASADIANTFER { get; set; }
        [XmlElement(ElementName = "FERIASCOLETIVAS")]
        public string FERIASCOLETIVAS { get; set; }
        [XmlElement(ElementName = "NRODIASABONO")]
        public string NRODIASABONO { get; set; }
        [XmlElement(ElementName = "SALDOFERIAS")]
        public string SALDOFERIAS { get; set; }
        [XmlElement(ElementName = "SALDOFERIASANT")]
        public string SALDOFERIASANT { get; set; }
        [XmlElement(ElementName = "SALDOFERANTAUX")]
        public string SALDOFERANTAUX { get; set; }
        [XmlElement(ElementName = "NDIASLICREM1")]
        public string NDIASLICREM1 { get; set; }
        [XmlElement(ElementName = "NDIASLICREM2")]
        public string NDIASLICREM2 { get; set; }
        [XmlElement(ElementName = "MEDIASALMATERN")]
        public string MEDIASALMATERN { get; set; }
        [XmlElement(ElementName = "SITUACAORAIS")]
        public string SITUACAORAIS { get; set; }
        [XmlElement(ElementName = "CONTAPAGAMENTO")]
        public string CONTAPAGAMENTO { get; set; }
        [XmlElement(ElementName = "MEMBROSINDICAL")]
        public string MEMBROSINDICAL { get; set; }
        [XmlElement(ElementName = "VINCULORAIS")]
        public string VINCULORAIS { get; set; }
        [XmlElement(ElementName = "DIASUTEISMES")]
        public string DIASUTEISMES { get; set; }
        [XmlElement(ElementName = "DIASUTMEIOEXP")]
        public string DIASUTMEIOEXP { get; set; }
        [XmlElement(ElementName = "DIASUTPROXMES")]
        public string DIASUTPROXMES { get; set; }
        [XmlElement(ElementName = "DIASUTPROXMEIO")]
        public string DIASUTPROXMEIO { get; set; }
        [XmlElement(ElementName = "DIASUTRESTANTES")]
        public string DIASUTRESTANTES { get; set; }
        [XmlElement(ElementName = "DIASUTRESTMEIO")]
        public string DIASUTRESTMEIO { get; set; }
        [XmlElement(ElementName = "MUDOUENDERECO")]
        public string MUDOUENDERECO { get; set; }
        [XmlElement(ElementName = "MUDOUCARTTRAB")]
        public string MUDOUCARTTRAB { get; set; }
        [XmlElement(ElementName = "MUDOUNOME")]
        public string MUDOUNOME { get; set; }
        [XmlElement(ElementName = "MUDOUPIS")]
        public string MUDOUPIS { get; set; }
        [XmlElement(ElementName = "ANTIGOPIS")]
        public string ANTIGOPIS { get; set; }
        [XmlElement(ElementName = "MUDOUCHAPA")]
        public string MUDOUCHAPA { get; set; }
        [XmlElement(ElementName = "MUDOUADMISSAO")]
        public string MUDOUADMISSAO { get; set; }
        [XmlElement(ElementName = "ANTIGOTIPOFUNC")]
        public string ANTIGOTIPOFUNC { get; set; }
        [XmlElement(ElementName = "ANTIGOTIPOADM")]
        public string ANTIGOTIPOADM { get; set; }
        [XmlElement(ElementName = "MUDOUDTOPCAO")]
        public string MUDOUDTOPCAO { get; set; }
        [XmlElement(ElementName = "MUDOUSECAO")]
        public string MUDOUSECAO { get; set; }
        [XmlElement(ElementName = "ANTIGASECAO")]
        public string ANTIGASECAO { get; set; }
        [XmlElement(ElementName = "MUDOUDTNASCIM")]
        public string MUDOUDTNASCIM { get; set; }
        [XmlElement(ElementName = "ANTIGADTNASCIM")]
        public string ANTIGADTNASCIM { get; set; }
        [XmlElement(ElementName = "FALTAALTERFGTS")]
        public string FALTAALTERFGTS { get; set; }
        [XmlElement(ElementName = "DEDUZIRRF65")]
        public string DEDUZIRRF65 { get; set; }
        [XmlElement(ElementName = "PISPARAFGTS")]
        public string PISPARAFGTS { get; set; }
        [XmlElement(ElementName = "ULTIMORECALCULODATA")]
        public string ULTIMORECALCULODATA { get; set; }
        [XmlElement(ElementName = "ULTIMORECALCULOHORA")]
        public string ULTIMORECALCULOHORA { get; set; }
        [XmlElement(ElementName = "DESCONTAAVISOPREVIO")]
        public string DESCONTAAVISOPREVIO { get; set; }
        [XmlElement(ElementName = "CODFILIAL")]
        public string CODFILIAL { get; set; }
        [XmlElement(ElementName = "NOME")]
        public string NOME { get; set; }
        [XmlElement(ElementName = "INDINICIOHOR")]
        public string INDINICIOHOR { get; set; }
        [XmlElement(ElementName = "PISPASEP")]
        public string PISPASEP { get; set; }
        [XmlElement(ElementName = "DTCADASTROPIS")]
        public string DTCADASTROPIS { get; set; }
        [XmlElement(ElementName = "CODPESSOA")]
        public string CODPESSOA { get; set; }
        [XmlElement(ElementName = "CODBANCOFGTS")]
        public string CODBANCOFGTS { get; set; }
        [XmlElement(ElementName = "CODBANCOPAGTO")]
        public string CODBANCOPAGTO { get; set; }
        [XmlElement(ElementName = "CODAGENCIAPAGTO")]
        public string CODAGENCIAPAGTO { get; set; }
        [XmlElement(ElementName = "CODBANCOPIS")]
        public string CODBANCOPIS { get; set; }
        [XmlElement(ElementName = "RESCISAOCALCULADA")]
        public string RESCISAOCALCULADA { get; set; }
        [XmlElement(ElementName = "MEMBROCIPA")]
        public string MEMBROCIPA { get; set; }
        [XmlElement(ElementName = "USASALCOMPOSTO")]
        public string USASALCOMPOSTO { get; set; }
        [XmlElement(ElementName = "REGATUAL")]
        public string REGATUAL { get; set; }
        [XmlElement(ElementName = "GRUPOSALARIAL")]
        public string GRUPOSALARIAL { get; set; }
        [XmlElement(ElementName = "JORNADAMENSAL")]
        public string JORNADAMENSAL { get; set; }
        [XmlElement(ElementName = "PREVDISP")]
        public string PREVDISP { get; set; }
        [XmlElement(ElementName = "CODOCORRENCIA")]
        public string CODOCORRENCIA { get; set; }
        [XmlElement(ElementName = "CODCATEGORIA")]
        public string CODCATEGORIA { get; set; }
        [XmlElement(ElementName = "ESUPERVISOR")]
        public string ESUPERVISOR { get; set; }
        [XmlElement(ElementName = "INTEGRCONTABIL")]
        public string INTEGRCONTABIL { get; set; }
        [XmlElement(ElementName = "USACONTROLEDESALDO")]
        public string USACONTROLEDESALDO { get; set; }
        [XmlElement(ElementName = "MUDOUCI")]
        public string MUDOUCI { get; set; }
        [XmlElement(ElementName = "PERIODORESCISAO")]
        public string PERIODORESCISAO { get; set; }
        [XmlElement(ElementName = "CODGRPQUIOSQUE")]
        public string CODGRPQUIOSQUE { get; set; }
        [XmlElement(ElementName = "FGTSMESANTRECOLGRFP")]
        public string FGTSMESANTRECOLGRFP { get; set; }
        [XmlElement(ElementName = "CODNIVELSAL")]
        public string CODNIVELSAL { get; set; }
        [XmlElement(ElementName = "TRABALHOUNADEMISSAO")]
        public string TRABALHOUNADEMISSAO { get; set; }
        [XmlElement(ElementName = "NRODIASFERIASJORNRED")]
        public string NRODIASFERIASJORNRED { get; set; }
        [XmlElement(ElementName = "POSSUIALVARAMENOR16")]
        public string POSSUIALVARAMENOR16 { get; set; }
        [XmlElement(ElementName = "SITUACAOINSS")]
        public string SITUACAOINSS { get; set; }
        [XmlElement(ElementName = "CODTABELASALARIAL")]
        public string CODTABELASALARIAL { get; set; }
        [XmlElement(ElementName = "TEMDEDUCAOCPMF")]
        public string TEMDEDUCAOCPMF { get; set; }
        [XmlElement(ElementName = "NRODIASFERIASCORRIDOS")]
        public string NRODIASFERIASCORRIDOS { get; set; }
        [XmlElement(ElementName = "NRODIASABONOCORRIDOS")]
        public string NRODIASABONOCORRIDOS { get; set; }
        [XmlElement(ElementName = "POSICAOABONO")]
        public string POSICAOABONO { get; set; }
        [XmlElement(ElementName = "QUERADIANTAMENTO")]
        public string QUERADIANTAMENTO { get; set; }
        [XmlElement(ElementName = "SEXO")]
        public string SEXO { get; set; }
        [XmlElement(ElementName = "NACIONALIDADE")]
        public string NACIONALIDADE { get; set; }
        [XmlElement(ElementName = "GRAUINSTRUCAO")]
        public string GRAUINSTRUCAO { get; set; }
        [XmlElement(ElementName = "NATURALIDADE")]
        public string NATURALIDADE { get; set; }
        [XmlElement(ElementName = "APELIDO")]
        public string APELIDO { get; set; }
        [XmlElement(ElementName = "EMAIL")]
        public string EMAIL { get; set; }
        [XmlElement(ElementName = "DTNASCIMENTO")]
        public string DTNASCIMENTO { get; set; }
        [XmlElement(ElementName = "CARTIDENTIDADE")]
        public string CARTIDENTIDADE { get; set; }
        [XmlElement(ElementName = "ORGEMISSORIDENT")]
        public string ORGEMISSORIDENT { get; set; }
        [XmlElement(ElementName = "DTEMISSAOIDENT")]
        public string DTEMISSAOIDENT { get; set; }
        [XmlElement(ElementName = "UFCARTIDENT")]
        public string UFCARTIDENT { get; set; }
        [XmlElement(ElementName = "CARTEIRATRAB")]
        public string CARTEIRATRAB { get; set; }
        [XmlElement(ElementName = "DTCARTTRAB")]
        public string DTCARTTRAB { get; set; }
        [XmlElement(ElementName = "SERIECARTTRAB")]
        public string SERIECARTTRAB { get; set; }
        [XmlElement(ElementName = "UFCARTTRAB")]
        public string UFCARTTRAB { get; set; }
        [XmlElement(ElementName = "NIT")]
        public string NIT { get; set; }
        [XmlElement(ElementName = "TITULOELEITOR")]
        public string TITULOELEITOR { get; set; }
        [XmlElement(ElementName = "SECAOTITELEITOR")]
        public string SECAOTITELEITOR { get; set; }
        [XmlElement(ElementName = "ZONATITELEITOR")]
        public string ZONATITELEITOR { get; set; }
        [XmlElement(ElementName = "CERTIFRESERV")]
        public string CERTIFRESERV { get; set; }
        [XmlElement(ElementName = "CATEGMILITAR")]
        public string CATEGMILITAR { get; set; }
        [XmlElement(ElementName = "CPF")]
        public string CPF { get; set; }
        [XmlElement(ElementName = "RUA")]
        public string RUA { get; set; }
        [XmlElement(ElementName = "NUMERO")]
        public string NUMERO { get; set; }
        [XmlElement(ElementName = "BAIRRO")]
        public string BAIRRO { get; set; }
        [XmlElement(ElementName = "CIDADE")]
        public string CIDADE { get; set; }
        [XmlElement(ElementName = "ESTADO")]
        public string ESTADO { get; set; }
        [XmlElement(ElementName = "PAIS")]
        public string PAIS { get; set; }
        [XmlElement(ElementName = "CEP")]
        public string CEP { get; set; }
        [XmlElement(ElementName = "TELEFONE1")]
        public string TELEFONE1 { get; set; }
        [XmlElement(ElementName = "NOMEBANCOPGTO")]
        public string NOMEBANCOPGTO { get; set; }
        [XmlElement(ElementName = "NOMEAGENCIAPGTO")]
        public string NOMEAGENCIAPGTO { get; set; }
        [XmlElement(ElementName = "NOMEPAI")]
        public string NOMEPAI { get; set; }
        [XmlElement(ElementName = "NOMEMAE")]
        public string NOMEMAE { get; set; }
        [XmlElement(ElementName = "CODIGO")]
        public string CODIGO { get; set; }
        [XmlElement(ElementName = "Jornada_Mensal")]
        public string Jornada_Mensal { get; set; }
        [XmlElement(ElementName = "Hora")]
        public string Hora { get; set; }
        [XmlElement(ElementName = "DEFICIENTEFISICO")]
        public string DEFICIENTEFISICO { get; set; }
        [XmlElement(ElementName = "DEFICIENTEAUDITIVO")]
        public string DEFICIENTEAUDITIVO { get; set; }
        [XmlElement(ElementName = "DEFICIENTEFALA")]
        public string DEFICIENTEFALA { get; set; }
        [XmlElement(ElementName = "DEFICIENTEVISUAL")]
        public string DEFICIENTEVISUAL { get; set; }
        [XmlElement(ElementName = "DEFICIENTEMENTAL")]
        public string DEFICIENTEMENTAL { get; set; }
        [XmlElement(ElementName = "BRPDH")]
        public string BRPDH { get; set; }
        [XmlElement(ElementName = "HSTAFT_ESTTEMPOSERVICO")]
        public string HSTAFT_ESTTEMPOSERVICO { get; set; }
        [XmlElement(ElementName = "IDIMAGEM")]
        public string IDIMAGEM { get; set; }
        [XmlElement(ElementName = "NOMEFUNC")]
        public string NOMEFUNC { get; set; }
        [XmlElement(ElementName = "CORRACA")]
        public string CORRACA { get; set; }
        [XmlElement(ElementName = "CODUSUARIO")]
        public string CODUSUARIO { get; set; }
        [XmlElement(ElementName = "ESTADOCIVIL")]
        public string ESTADOCIVIL { get; set; }
        [XmlElement(ElementName = "ESTADONATAL")]
        public string ESTADONATAL { get; set; }
        [XmlElement(ElementName = "CANDIDATO")]
        public string CANDIDATO { get; set; }
        [XmlElement(ElementName = "CODCOLIGADAORIGEM")]
        public string CODCOLIGADAORIGEM { get; set; }
        [XmlElement(ElementName = "CHAPAORIGEM")]
        public string CHAPAORIGEM { get; set; }
        [XmlElement(ElementName = "DEFICIENTEINTELECTUAL")]
        public string DEFICIENTEINTELECTUAL { get; set; }
        [XmlElement(ElementName = "SITUACAOIRRF")]
        public string SITUACAOIRRF { get; set; }
        [XmlElement(ElementName = "NROFILHOSBRASIL")]
        public string NROFILHOSBRASIL { get; set; }
        [XmlElement(ElementName = "CODIGORECEITA3533")]
        public string CODIGORECEITA3533 { get; set; }
        [XmlElement(ElementName = "IDADE")]
        public string IDADE { get; set; }
        [XmlElement(ElementName = "ESOCIALNATATIVIDADE")]
        public string ESOCIALNATATIVIDADE { get; set; }
        [XmlElement(ElementName = "FUMANTE")]
        public string FUMANTE { get; set; }
        [XmlElement(ElementName = "IMAGEM")]
        public string IMAGEM { get; set; }
        [XmlElement(ElementName = "DEFICIENTEMOBREDUZIDA")]
        public string DEFICIENTEMOBREDUZIDA { get; set; }
        [XmlElement(ElementName = "Periodo_Aquisitivo")]
        public string Periodo_Aquisitivo { get; set; }
        [XmlElement(ElementName = "Limite_Ferias_Dobro")]
        public string Limite_Ferias_Dobro { get; set; }
        [XmlElement(ElementName = "DiasFaltasFeriasNormais")]
        public string DiasFaltasFeriasNormais { get; set; }
        [XmlElement(ElementName = "CONJUGEBRASIL")]
        public string CONJUGEBRASIL { get; set; }
        [XmlElement(ElementName = "NATURALIZADO")]
        public string NATURALIZADO { get; set; }
        [XmlElement(ElementName = "FILHOSBRASIL")]
        public string FILHOSBRASIL { get; set; }
        [XmlElement(ElementName = "INVESTTREINANT")]
        public string INVESTTREINANT { get; set; }
        [XmlElement(ElementName = "AJUSTATAMANHOFOTO")]
        public string AJUSTATAMANHOFOTO { get; set; }
        [XmlElement(ElementName = "DATAAPROVACAOCURR")]
        public string DATAAPROVACAOCURR { get; set; }
        [XmlElement(ElementName = "ESTADOROW")]
        public string ESTADOROW { get; set; }
        [XmlElement(ElementName = "ROWVALIDA")]
        public string ROWVALIDA { get; set; }
        [XmlElement(ElementName = "ALUNO")]
        public string ALUNO { get; set; }
        [XmlElement(ElementName = "PROFESSOR")]
        public string PROFESSOR { get; set; }
        [XmlElement(ElementName = "USUARIOBIBLIOS")]
        public string USUARIOBIBLIOS { get; set; }
        [XmlElement(ElementName = "FUNCIONARIO")]
        public string FUNCIONARIO { get; set; }
        [XmlElement(ElementName = "EXFUNCIONARIO")]
        public string EXFUNCIONARIO { get; set; }
        [XmlElement(ElementName = "FALECIDO")]
        public string FALECIDO { get; set; }
    }

    [XmlRoot(ElementName = "PFCOMPL")]
    public class PFCOMPL
    {
        [XmlElement(ElementName = "CODCOLIGADA")]
        public string CODCOLIGADA { get; set; }
        [XmlElement(ElementName = "CHAPA")]
        public string CHAPA { get; set; }
        [XmlElement(ElementName = "SANGUE")]
        public string SANGUE { get; set; }
        [XmlElement(ElementName = "CESTABASICA")]
        public string CESTABASICA { get; set; }
        [XmlElement(ElementName = "CONFBB")]
        public string CONFBB { get; set; }
        [XmlElement(ElementName = "MANEQUIM")]
        public string MANEQUIM { get; set; }
        [XmlElement(ElementName = "NUMEROSAPATO")]
        public string NUMEROSAPATO { get; set; }
        [XmlElement(ElementName = "MESNASCIMENTO")]
        public string MESNASCIMENTO { get; set; }
        [XmlElement(ElementName = "TAMBOTA")]
        public string TAMBOTA { get; set; }
        [XmlElement(ElementName = "DTCASAMENTO")]
        public string DTCASAMENTO { get; set; }
        [XmlElement(ElementName = "TIPOSANGUE")]
        public string TIPOSANGUE { get; set; }
        [XmlElement(ElementName = "CTA")]
        public string CTA { get; set; }
        [XmlElement(ElementName = "CNPJCONTASSIST")]
        public string CNPJCONTASSIST { get; set; }
    }

    [XmlRoot(ElementName = "VPCOMPL")]
    public class VPCOMPL
    {
        [XmlElement(ElementName = "CODPESSOA")]
        public string CODPESSOA { get; set; }
        [XmlElement(ElementName = "IDADE")]
        public string IDADE { get; set; }
        [XmlElement(ElementName = "PESO")]
        public string PESO { get; set; }
    }

    [XmlRoot(ElementName = "FopFunc")]
    public class FopFunc
    {
        [XmlElement(ElementName = "PFunc")]
        public PFunc PFunc { get; set; }
        [XmlElement(ElementName = "PFCOMPL")]
        public PFCOMPL PFCOMPL { get; set; }
        [XmlElement(ElementName = "VPCOMPL")]
        public VPCOMPL VPCOMPL { get; set; }
    }

}