using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using ApihubDateConverter = IO.RccFicoscore.Client.ApihubDateConverter;

namespace IO.RccFicoscore.Model
{
    [DataContract]
    public partial class Credito :  IEquatable<Credito>, IValidatableObject
    {
        [DataMember(Name="tipoResponsabilidad", EmitDefaultValue=false)]
        public CatalogoTipoResponsabilidad? TipoResponsabilidad { get; set; }
        [DataMember(Name="tipoCuenta", EmitDefaultValue=false)]
        public CatalogoTipoCuenta? TipoCuenta { get; set; }
        [DataMember(Name="tipoCredito", EmitDefaultValue=false)]
        public CatalogoTipoCredito? TipoCredito { get; set; }
        [DataMember(Name="claveUnidadMonetaria", EmitDefaultValue=false)]
        public CatalogoMoneda? ClaveUnidadMonetaria { get; set; }
        [DataMember(Name="frecuenciaPagos", EmitDefaultValue=false)]
        public CatalogoFrecuenciaPago? FrecuenciaPagos { get; set; }
        [DataMember(Name="clavePrevencion", EmitDefaultValue=false)]
        public CatalogoPrevencion? ClavePrevencion { get; set; }
        public Credito(string fechaActualizacion = default(string), int? registroImpugnado = default(int?), string claveOtorgante = default(string), string nombreOtorgante = default(string), string cuentaActual = default(string), CatalogoTipoResponsabilidad? tipoResponsabilidad = default(CatalogoTipoResponsabilidad?), CatalogoTipoCuenta? tipoCuenta = default(CatalogoTipoCuenta?), CatalogoTipoCredito? tipoCredito = default(CatalogoTipoCredito?), CatalogoMoneda? claveUnidadMonetaria = default(CatalogoMoneda?), int? valorActivoValuacion = default(int?), int? numeroPagos = default(int?), CatalogoFrecuenciaPago? frecuenciaPagos = default(CatalogoFrecuenciaPago?), float? montoPagar = default(float?), string fechaAperturaCuenta = default(string), string fechaUltimoPago = default(string), string fechaUltimaCompra = default(string), string fechaCierreCuenta = default(string), string fechaReporte = default(string), string ultimaFechaSaldoCero = default(string), string garantia = default(string), float? creditoMaximo = default(float?), float? saldoActual = default(float?), float? limiteCredito = default(float?), float? saldoVencido = default(float?), int? numeroPagosVencidos = default(int?), string pagoActual = default(string), string historicoPagos = default(string), string fechaRecienteHistoricoPagos = default(string), string fechaAntiguaHistoricoPagos = default(string), CatalogoPrevencion? clavePrevencion = default(CatalogoPrevencion?), int? totalPagosReportados = default(int?), float? peorAtraso = default(float?), string fechaPeorAtraso = default(string), float? saldoVencidoPeorAtraso = default(float?), double? montoUltimoPago = default(double?), string idDomicilio = default(string), string servicios = default(string), CAN cAN = default(CAN))
        {
            this.FechaActualizacion = fechaActualizacion;
            this.RegistroImpugnado = registroImpugnado;
            this.ClaveOtorgante = claveOtorgante;
            this.NombreOtorgante = nombreOtorgante;
            this.CuentaActual = cuentaActual;
            this.TipoResponsabilidad = tipoResponsabilidad;
            this.TipoCuenta = tipoCuenta;
            this.TipoCredito = tipoCredito;
            this.ClaveUnidadMonetaria = claveUnidadMonetaria;
            this.ValorActivoValuacion = valorActivoValuacion;
            this.NumeroPagos = numeroPagos;
            this.FrecuenciaPagos = frecuenciaPagos;
            this.MontoPagar = montoPagar;
            this.FechaAperturaCuenta = fechaAperturaCuenta;
            this.FechaUltimoPago = fechaUltimoPago;
            this.FechaUltimaCompra = fechaUltimaCompra;
            this.FechaCierreCuenta = fechaCierreCuenta;
            this.FechaReporte = fechaReporte;
            this.UltimaFechaSaldoCero = ultimaFechaSaldoCero;
            this.Garantia = garantia;
            this.CreditoMaximo = creditoMaximo;
            this.SaldoActual = saldoActual;
            this.LimiteCredito = limiteCredito;
            this.SaldoVencido = saldoVencido;
            this.NumeroPagosVencidos = numeroPagosVencidos;
            this.PagoActual = pagoActual;
            this.HistoricoPagos = historicoPagos;
            this.FechaRecienteHistoricoPagos = fechaRecienteHistoricoPagos;
            this.FechaAntiguaHistoricoPagos = fechaAntiguaHistoricoPagos;
            this.ClavePrevencion = clavePrevencion;
            this.TotalPagosReportados = totalPagosReportados;
            this.PeorAtraso = peorAtraso;
            this.FechaPeorAtraso = fechaPeorAtraso;
            this.SaldoVencidoPeorAtraso = saldoVencidoPeorAtraso;
            this.MontoUltimoPago = montoUltimoPago;
            this.IdDomicilio = idDomicilio;
            this.Servicios = servicios;
            this.CAN = cAN;
        }
        [DataMember(Name="fechaActualizacion", EmitDefaultValue=false)]
        public string FechaActualizacion { get; set; }
        [DataMember(Name="registroImpugnado", EmitDefaultValue=false)]
        public int? RegistroImpugnado { get; set; }
        [DataMember(Name="claveOtorgante", EmitDefaultValue=false)]
        public string ClaveOtorgante { get; set; }
        [DataMember(Name="nombreOtorgante", EmitDefaultValue=false)]
        public string NombreOtorgante { get; set; }
        [DataMember(Name="cuentaActual", EmitDefaultValue=false)]
        public string CuentaActual { get; set; }
        [DataMember(Name="valorActivoValuacion", EmitDefaultValue=false)]
        public int? ValorActivoValuacion { get; set; }
        [DataMember(Name="numeroPagos", EmitDefaultValue=false)]
        public int? NumeroPagos { get; set; }
        [DataMember(Name="montoPagar", EmitDefaultValue=false)]
        public float? MontoPagar { get; set; }
        [DataMember(Name="fechaAperturaCuenta", EmitDefaultValue=false)]
        public string FechaAperturaCuenta { get; set; }
        [DataMember(Name="fechaUltimoPago", EmitDefaultValue=false)]
        public string FechaUltimoPago { get; set; }
        [DataMember(Name="fechaUltimaCompra", EmitDefaultValue=false)]
        public string FechaUltimaCompra { get; set; }
        [DataMember(Name="fechaCierreCuenta", EmitDefaultValue=false)]
        public string FechaCierreCuenta { get; set; }
        [DataMember(Name="fechaReporte", EmitDefaultValue=false)]
        public string FechaReporte { get; set; }
        [DataMember(Name="ultimaFechaSaldoCero", EmitDefaultValue=false)]
        public string UltimaFechaSaldoCero { get; set; }
        [DataMember(Name="garantia", EmitDefaultValue=false)]
        public string Garantia { get; set; }
        [DataMember(Name="creditoMaximo", EmitDefaultValue=false)]
        public float? CreditoMaximo { get; set; }
        [DataMember(Name="saldoActual", EmitDefaultValue=false)]
        public float? SaldoActual { get; set; }
        [DataMember(Name="limiteCredito", EmitDefaultValue=false)]
        public float? LimiteCredito { get; set; }
        [DataMember(Name="saldoVencido", EmitDefaultValue=false)]
        public float? SaldoVencido { get; set; }
        [DataMember(Name="numeroPagosVencidos", EmitDefaultValue=false)]
        public int? NumeroPagosVencidos { get; set; }
        [DataMember(Name="pagoActual", EmitDefaultValue=false)]
        public string PagoActual { get; set; }
        [DataMember(Name="historicoPagos", EmitDefaultValue=false)]
        public string HistoricoPagos { get; set; }
        [DataMember(Name="fechaRecienteHistoricoPagos", EmitDefaultValue=false)]
        public string FechaRecienteHistoricoPagos { get; set; }
        [DataMember(Name="fechaAntiguaHistoricoPagos", EmitDefaultValue=false)]
        public string FechaAntiguaHistoricoPagos { get; set; }
        [DataMember(Name="totalPagosReportados", EmitDefaultValue=false)]
        public int? TotalPagosReportados { get; set; }
        [DataMember(Name="peorAtraso", EmitDefaultValue=false)]
        public float? PeorAtraso { get; set; }
        [DataMember(Name="fechaPeorAtraso", EmitDefaultValue=false)]
        public string FechaPeorAtraso { get; set; }
        [DataMember(Name="saldoVencidoPeorAtraso", EmitDefaultValue=false)]
        public float? SaldoVencidoPeorAtraso { get; set; }
        [DataMember(Name="montoUltimoPago", EmitDefaultValue=false)]
        public double? MontoUltimoPago { get; set; }
        [DataMember(Name="idDomicilio", EmitDefaultValue=false)]
        public string IdDomicilio { get; set; }
        [DataMember(Name="servicios", EmitDefaultValue=false)]
        public string Servicios { get; set; }
        [DataMember(Name="CAN", EmitDefaultValue=false)]
        public CAN CAN { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Credito {\n");
            sb.Append("  FechaActualizacion: ").Append(FechaActualizacion).Append("\n");
            sb.Append("  RegistroImpugnado: ").Append(RegistroImpugnado).Append("\n");
            sb.Append("  ClaveOtorgante: ").Append(ClaveOtorgante).Append("\n");
            sb.Append("  NombreOtorgante: ").Append(NombreOtorgante).Append("\n");
            sb.Append("  CuentaActual: ").Append(CuentaActual).Append("\n");
            sb.Append("  TipoResponsabilidad: ").Append(TipoResponsabilidad).Append("\n");
            sb.Append("  TipoCuenta: ").Append(TipoCuenta).Append("\n");
            sb.Append("  TipoCredito: ").Append(TipoCredito).Append("\n");
            sb.Append("  ClaveUnidadMonetaria: ").Append(ClaveUnidadMonetaria).Append("\n");
            sb.Append("  ValorActivoValuacion: ").Append(ValorActivoValuacion).Append("\n");
            sb.Append("  NumeroPagos: ").Append(NumeroPagos).Append("\n");
            sb.Append("  FrecuenciaPagos: ").Append(FrecuenciaPagos).Append("\n");
            sb.Append("  MontoPagar: ").Append(MontoPagar).Append("\n");
            sb.Append("  FechaAperturaCuenta: ").Append(FechaAperturaCuenta).Append("\n");
            sb.Append("  FechaUltimoPago: ").Append(FechaUltimoPago).Append("\n");
            sb.Append("  FechaUltimaCompra: ").Append(FechaUltimaCompra).Append("\n");
            sb.Append("  FechaCierreCuenta: ").Append(FechaCierreCuenta).Append("\n");
            sb.Append("  FechaReporte: ").Append(FechaReporte).Append("\n");
            sb.Append("  UltimaFechaSaldoCero: ").Append(UltimaFechaSaldoCero).Append("\n");
            sb.Append("  Garantia: ").Append(Garantia).Append("\n");
            sb.Append("  CreditoMaximo: ").Append(CreditoMaximo).Append("\n");
            sb.Append("  SaldoActual: ").Append(SaldoActual).Append("\n");
            sb.Append("  LimiteCredito: ").Append(LimiteCredito).Append("\n");
            sb.Append("  SaldoVencido: ").Append(SaldoVencido).Append("\n");
            sb.Append("  NumeroPagosVencidos: ").Append(NumeroPagosVencidos).Append("\n");
            sb.Append("  PagoActual: ").Append(PagoActual).Append("\n");
            sb.Append("  HistoricoPagos: ").Append(HistoricoPagos).Append("\n");
            sb.Append("  FechaRecienteHistoricoPagos: ").Append(FechaRecienteHistoricoPagos).Append("\n");
            sb.Append("  FechaAntiguaHistoricoPagos: ").Append(FechaAntiguaHistoricoPagos).Append("\n");
            sb.Append("  ClavePrevencion: ").Append(ClavePrevencion).Append("\n");
            sb.Append("  TotalPagosReportados: ").Append(TotalPagosReportados).Append("\n");
            sb.Append("  PeorAtraso: ").Append(PeorAtraso).Append("\n");
            sb.Append("  FechaPeorAtraso: ").Append(FechaPeorAtraso).Append("\n");
            sb.Append("  SaldoVencidoPeorAtraso: ").Append(SaldoVencidoPeorAtraso).Append("\n");
            sb.Append("  MontoUltimoPago: ").Append(MontoUltimoPago).Append("\n");
            sb.Append("  IdDomicilio: ").Append(IdDomicilio).Append("\n");
            sb.Append("  Servicios: ").Append(Servicios).Append("\n");
            sb.Append("  CAN: ").Append(CAN).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as Credito);
        }
        public bool Equals(Credito input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.FechaActualizacion == input.FechaActualizacion ||
                    (this.FechaActualizacion != null &&
                    this.FechaActualizacion.Equals(input.FechaActualizacion))
                ) && 
                (
                    this.RegistroImpugnado == input.RegistroImpugnado ||
                    (this.RegistroImpugnado != null &&
                    this.RegistroImpugnado.Equals(input.RegistroImpugnado))
                ) && 
                (
                    this.ClaveOtorgante == input.ClaveOtorgante ||
                    (this.ClaveOtorgante != null &&
                    this.ClaveOtorgante.Equals(input.ClaveOtorgante))
                ) && 
                (
                    this.NombreOtorgante == input.NombreOtorgante ||
                    (this.NombreOtorgante != null &&
                    this.NombreOtorgante.Equals(input.NombreOtorgante))
                ) && 
                (
                    this.CuentaActual == input.CuentaActual ||
                    (this.CuentaActual != null &&
                    this.CuentaActual.Equals(input.CuentaActual))
                ) && 
                (
                    this.TipoResponsabilidad == input.TipoResponsabilidad ||
                    (this.TipoResponsabilidad != null &&
                    this.TipoResponsabilidad.Equals(input.TipoResponsabilidad))
                ) && 
                (
                    this.TipoCuenta == input.TipoCuenta ||
                    (this.TipoCuenta != null &&
                    this.TipoCuenta.Equals(input.TipoCuenta))
                ) && 
                (
                    this.TipoCredito == input.TipoCredito ||
                    (this.TipoCredito != null &&
                    this.TipoCredito.Equals(input.TipoCredito))
                ) && 
                (
                    this.ClaveUnidadMonetaria == input.ClaveUnidadMonetaria ||
                    (this.ClaveUnidadMonetaria != null &&
                    this.ClaveUnidadMonetaria.Equals(input.ClaveUnidadMonetaria))
                ) && 
                (
                    this.ValorActivoValuacion == input.ValorActivoValuacion ||
                    (this.ValorActivoValuacion != null &&
                    this.ValorActivoValuacion.Equals(input.ValorActivoValuacion))
                ) && 
                (
                    this.NumeroPagos == input.NumeroPagos ||
                    (this.NumeroPagos != null &&
                    this.NumeroPagos.Equals(input.NumeroPagos))
                ) && 
                (
                    this.FrecuenciaPagos == input.FrecuenciaPagos ||
                    (this.FrecuenciaPagos != null &&
                    this.FrecuenciaPagos.Equals(input.FrecuenciaPagos))
                ) && 
                (
                    this.MontoPagar == input.MontoPagar ||
                    (this.MontoPagar != null &&
                    this.MontoPagar.Equals(input.MontoPagar))
                ) && 
                (
                    this.FechaAperturaCuenta == input.FechaAperturaCuenta ||
                    (this.FechaAperturaCuenta != null &&
                    this.FechaAperturaCuenta.Equals(input.FechaAperturaCuenta))
                ) && 
                (
                    this.FechaUltimoPago == input.FechaUltimoPago ||
                    (this.FechaUltimoPago != null &&
                    this.FechaUltimoPago.Equals(input.FechaUltimoPago))
                ) && 
                (
                    this.FechaUltimaCompra == input.FechaUltimaCompra ||
                    (this.FechaUltimaCompra != null &&
                    this.FechaUltimaCompra.Equals(input.FechaUltimaCompra))
                ) && 
                (
                    this.FechaCierreCuenta == input.FechaCierreCuenta ||
                    (this.FechaCierreCuenta != null &&
                    this.FechaCierreCuenta.Equals(input.FechaCierreCuenta))
                ) && 
                (
                    this.FechaReporte == input.FechaReporte ||
                    (this.FechaReporte != null &&
                    this.FechaReporte.Equals(input.FechaReporte))
                ) && 
                (
                    this.UltimaFechaSaldoCero == input.UltimaFechaSaldoCero ||
                    (this.UltimaFechaSaldoCero != null &&
                    this.UltimaFechaSaldoCero.Equals(input.UltimaFechaSaldoCero))
                ) && 
                (
                    this.Garantia == input.Garantia ||
                    (this.Garantia != null &&
                    this.Garantia.Equals(input.Garantia))
                ) && 
                (
                    this.CreditoMaximo == input.CreditoMaximo ||
                    (this.CreditoMaximo != null &&
                    this.CreditoMaximo.Equals(input.CreditoMaximo))
                ) && 
                (
                    this.SaldoActual == input.SaldoActual ||
                    (this.SaldoActual != null &&
                    this.SaldoActual.Equals(input.SaldoActual))
                ) && 
                (
                    this.LimiteCredito == input.LimiteCredito ||
                    (this.LimiteCredito != null &&
                    this.LimiteCredito.Equals(input.LimiteCredito))
                ) && 
                (
                    this.SaldoVencido == input.SaldoVencido ||
                    (this.SaldoVencido != null &&
                    this.SaldoVencido.Equals(input.SaldoVencido))
                ) && 
                (
                    this.NumeroPagosVencidos == input.NumeroPagosVencidos ||
                    (this.NumeroPagosVencidos != null &&
                    this.NumeroPagosVencidos.Equals(input.NumeroPagosVencidos))
                ) && 
                (
                    this.PagoActual == input.PagoActual ||
                    (this.PagoActual != null &&
                    this.PagoActual.Equals(input.PagoActual))
                ) && 
                (
                    this.HistoricoPagos == input.HistoricoPagos ||
                    (this.HistoricoPagos != null &&
                    this.HistoricoPagos.Equals(input.HistoricoPagos))
                ) && 
                (
                    this.FechaRecienteHistoricoPagos == input.FechaRecienteHistoricoPagos ||
                    (this.FechaRecienteHistoricoPagos != null &&
                    this.FechaRecienteHistoricoPagos.Equals(input.FechaRecienteHistoricoPagos))
                ) && 
                (
                    this.FechaAntiguaHistoricoPagos == input.FechaAntiguaHistoricoPagos ||
                    (this.FechaAntiguaHistoricoPagos != null &&
                    this.FechaAntiguaHistoricoPagos.Equals(input.FechaAntiguaHistoricoPagos))
                ) && 
                (
                    this.ClavePrevencion == input.ClavePrevencion ||
                    (this.ClavePrevencion != null &&
                    this.ClavePrevencion.Equals(input.ClavePrevencion))
                ) && 
                (
                    this.TotalPagosReportados == input.TotalPagosReportados ||
                    (this.TotalPagosReportados != null &&
                    this.TotalPagosReportados.Equals(input.TotalPagosReportados))
                ) && 
                (
                    this.PeorAtraso == input.PeorAtraso ||
                    (this.PeorAtraso != null &&
                    this.PeorAtraso.Equals(input.PeorAtraso))
                ) && 
                (
                    this.FechaPeorAtraso == input.FechaPeorAtraso ||
                    (this.FechaPeorAtraso != null &&
                    this.FechaPeorAtraso.Equals(input.FechaPeorAtraso))
                ) && 
                (
                    this.SaldoVencidoPeorAtraso == input.SaldoVencidoPeorAtraso ||
                    (this.SaldoVencidoPeorAtraso != null &&
                    this.SaldoVencidoPeorAtraso.Equals(input.SaldoVencidoPeorAtraso))
                ) && 
                (
                    this.MontoUltimoPago == input.MontoUltimoPago ||
                    (this.MontoUltimoPago != null &&
                    this.MontoUltimoPago.Equals(input.MontoUltimoPago))
                ) && 
                (
                    this.IdDomicilio == input.IdDomicilio ||
                    (this.IdDomicilio != null &&
                    this.IdDomicilio.Equals(input.IdDomicilio))
                ) && 
                (
                    this.Servicios == input.Servicios ||
                    (this.Servicios != null &&
                    this.Servicios.Equals(input.Servicios))
                ) && 
                (
                    this.CAN == input.CAN ||
                    (this.CAN != null &&
                    this.CAN.Equals(input.CAN))
                );
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 41;
                if (this.FechaActualizacion != null)
                    hashCode = hashCode * 59 + this.FechaActualizacion.GetHashCode();
                if (this.RegistroImpugnado != null)
                    hashCode = hashCode * 59 + this.RegistroImpugnado.GetHashCode();
                if (this.ClaveOtorgante != null)
                    hashCode = hashCode * 59 + this.ClaveOtorgante.GetHashCode();
                if (this.NombreOtorgante != null)
                    hashCode = hashCode * 59 + this.NombreOtorgante.GetHashCode();
                if (this.CuentaActual != null)
                    hashCode = hashCode * 59 + this.CuentaActual.GetHashCode();
                if (this.TipoResponsabilidad != null)
                    hashCode = hashCode * 59 + this.TipoResponsabilidad.GetHashCode();
                if (this.TipoCuenta != null)
                    hashCode = hashCode * 59 + this.TipoCuenta.GetHashCode();
                if (this.TipoCredito != null)
                    hashCode = hashCode * 59 + this.TipoCredito.GetHashCode();
                if (this.ClaveUnidadMonetaria != null)
                    hashCode = hashCode * 59 + this.ClaveUnidadMonetaria.GetHashCode();
                if (this.ValorActivoValuacion != null)
                    hashCode = hashCode * 59 + this.ValorActivoValuacion.GetHashCode();
                if (this.NumeroPagos != null)
                    hashCode = hashCode * 59 + this.NumeroPagos.GetHashCode();
                if (this.FrecuenciaPagos != null)
                    hashCode = hashCode * 59 + this.FrecuenciaPagos.GetHashCode();
                if (this.MontoPagar != null)
                    hashCode = hashCode * 59 + this.MontoPagar.GetHashCode();
                if (this.FechaAperturaCuenta != null)
                    hashCode = hashCode * 59 + this.FechaAperturaCuenta.GetHashCode();
                if (this.FechaUltimoPago != null)
                    hashCode = hashCode * 59 + this.FechaUltimoPago.GetHashCode();
                if (this.FechaUltimaCompra != null)
                    hashCode = hashCode * 59 + this.FechaUltimaCompra.GetHashCode();
                if (this.FechaCierreCuenta != null)
                    hashCode = hashCode * 59 + this.FechaCierreCuenta.GetHashCode();
                if (this.FechaReporte != null)
                    hashCode = hashCode * 59 + this.FechaReporte.GetHashCode();
                if (this.UltimaFechaSaldoCero != null)
                    hashCode = hashCode * 59 + this.UltimaFechaSaldoCero.GetHashCode();
                if (this.Garantia != null)
                    hashCode = hashCode * 59 + this.Garantia.GetHashCode();
                if (this.CreditoMaximo != null)
                    hashCode = hashCode * 59 + this.CreditoMaximo.GetHashCode();
                if (this.SaldoActual != null)
                    hashCode = hashCode * 59 + this.SaldoActual.GetHashCode();
                if (this.LimiteCredito != null)
                    hashCode = hashCode * 59 + this.LimiteCredito.GetHashCode();
                if (this.SaldoVencido != null)
                    hashCode = hashCode * 59 + this.SaldoVencido.GetHashCode();
                if (this.NumeroPagosVencidos != null)
                    hashCode = hashCode * 59 + this.NumeroPagosVencidos.GetHashCode();
                if (this.PagoActual != null)
                    hashCode = hashCode * 59 + this.PagoActual.GetHashCode();
                if (this.HistoricoPagos != null)
                    hashCode = hashCode * 59 + this.HistoricoPagos.GetHashCode();
                if (this.FechaRecienteHistoricoPagos != null)
                    hashCode = hashCode * 59 + this.FechaRecienteHistoricoPagos.GetHashCode();
                if (this.FechaAntiguaHistoricoPagos != null)
                    hashCode = hashCode * 59 + this.FechaAntiguaHistoricoPagos.GetHashCode();
                if (this.ClavePrevencion != null)
                    hashCode = hashCode * 59 + this.ClavePrevencion.GetHashCode();
                if (this.TotalPagosReportados != null)
                    hashCode = hashCode * 59 + this.TotalPagosReportados.GetHashCode();
                if (this.PeorAtraso != null)
                    hashCode = hashCode * 59 + this.PeorAtraso.GetHashCode();
                if (this.FechaPeorAtraso != null)
                    hashCode = hashCode * 59 + this.FechaPeorAtraso.GetHashCode();
                if (this.SaldoVencidoPeorAtraso != null)
                    hashCode = hashCode * 59 + this.SaldoVencidoPeorAtraso.GetHashCode();
                if (this.MontoUltimoPago != null)
                    hashCode = hashCode * 59 + this.MontoUltimoPago.GetHashCode();
                if (this.IdDomicilio != null)
                    hashCode = hashCode * 59 + this.IdDomicilio.GetHashCode();
                if (this.Servicios != null)
                    hashCode = hashCode * 59 + this.Servicios.GetHashCode();
                if (this.CAN != null)
                    hashCode = hashCode * 59 + this.CAN.GetHashCode();
                return hashCode;
            }
        }
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            if(this.ClaveOtorgante != null && this.ClaveOtorgante.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClaveOtorgante, length must be less than 10.", new [] { "ClaveOtorgante" });
            }
            if(this.NombreOtorgante != null && this.NombreOtorgante.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NombreOtorgante, length must be less than 40.", new [] { "NombreOtorgante" });
            }
            if(this.CuentaActual != null && this.CuentaActual.Length > 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CuentaActual, length must be less than 25.", new [] { "CuentaActual" });
            }
            yield break;
        }
    }
}
