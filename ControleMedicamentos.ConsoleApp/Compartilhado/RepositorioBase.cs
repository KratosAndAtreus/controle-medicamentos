using System.Collections;

namespace ControleMedicamentos.ConsoleApp.Compartilhado
{
    internal abstract class RepositorioBase
    {
        protected ArrayList registros = new ArrayList();

        protected int contadorId = 1;

        public void Cadastrar(EntidadeBase novoRegistro)
        {
            novoRegistro.Id = contadorId++;

            registros.Add(novoRegistro);
        }

        public bool Editar(int id, EntidadeBase novaEntidade)
        {
            novaEntidade.Id = id;

            foreach (EntidadeBase registro in registros)
            {
                if (registro == null)
                    continue;

                else if (registro.Id == id)
                {
                    registro.AtualizarRegistro(novaEntidade);

                    return true;
                }
            }

            return false;
        }

        public bool Excluir(int id)
        {
            foreach (EntidadeBase registro in registros)
            {
                if (registro == null)
                    continue;

                else if (registro.Id == id)
                {
                    registros.Remove(registro);
                    return true;
                }
            }
            

            return false;
        }

        public ArrayList SelecionarTodos()
        {
            return registros;
        }

        public EntidadeBase SelecionarPorId(int id)
        {
            foreach (EntidadeBase e in registros)
            {
                if (e == null)
                    continue;

                else if (e.Id == id)
                    return e;
            }

            return null;
        }

        public bool Existe(int id)
        {
            foreach (EntidadeBase e in registros)
            {
                if (e == null)
                    continue;

                else if (e.Id == id)
                    return true;
            }

            return false;
        }
    }
}
