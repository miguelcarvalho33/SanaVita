
"""
Script: import_access_to_sqlserver.py

Importa todas as tabelas da base Access (.mdb) para SQL Server em ordem segura,
respeitando dependências de foreign keys.

Requisitos:
- Python 3.10+
- pyodbc instalado: pip install pyodbc
- Driver "Microsoft Access Database Engine" instalado
"""

import pyodbc

# Caminhos e conexões
access_path = r"D:\Areas\Mestrado\Sistemas Distribuídos em Larga Escala\CITS20220208AH\CITS20220208AH.mdb"
sql_conn_str = (
    "DRIVER={ODBC Driver 17 for SQL Server};"
    "SERVER=MATEBOOK_MC\\SQLEXPRESS;"
    "DATABASE=SanaVita;"
    "Trusted_Connection=yes;"
)

# Ordem ideal de importação com base em foreign keys
import_order = [
    # REFERÊNCIAS
    'REF_SEXO', 'REF_UNIDADE', 'REF_UNIDADE_TEMPORAL', 'REF_TIPO_ALERTA', 'REF_TIPO_APRESENTACAO',
    'REF_TIPO_AUTORIZ', 'REF_TIPO_DESTINATARIO', 'REF_TIPO_EMB', 'REF_TIPO_PRECO',
    'REF_TIPO_PROCEDIMENTO', 'REF_TIPO_PRODUTO', 'REF_TIPO_REGIME', 'REF_TIPO_TRATAMENTO',
    'REF_TITULAR_AIM', 'REF_VIA_ADMIN', 'REF_TEMPERATURA_ARMAZ', 'REF_ESTADO_ARMAZ',
    'REF_ESTADO_COMERC', 'REF_ESTADO_EMB', 'REF_ESTADO_AIM', 'REF_COND_CONSERVACAO',
    'REF_NIVEL_COMPART', 'REF_REGIME_EXCECIONAL', 'REF_MOTIVO_ESCOAM', 'REF_LOCAL_DISPENSA',
    'REF_NORMA_REG_EXC', 'REF_CLASS_ESTP_PSICTR', 'REF_CLASS_DISPENSA_PROD', 'REF_GRUPO_HOM',
    'REF_GRUPO_PRODUTO', 'REF_SUBGRUPO_PRODUTO', 'REF_SUBSTANCIA', 'REF_CHNM', 'REF_ATC', 'REF_CFT',
    'REF_DCIPT', 'REF_FORMA_FARM', 'REF_AGRUP_FORMA_FARM', 'REF_ACOND_PRIMARIO',
    
    # PRINCIPAIS
    'PRODUTO', 'EMBALAGEM', 'ALERTA',

    # SECUNDÁRIAS
    'COMERCIALIZACAO', 'COND_ARMAZENAMENTO', 'ESCOAMENTO', 'COMPARTICIPACAO', 'PRECO',

    # LIGAÇÕES
    'DOCUMENTO_ALERTA', 'MENSAGEM_ALERTA',
    'LNK_PROD_ATC', 'LNK_PROD_CFT', 'LNK_PROD_CLASS_DISP', 'LNK_PROD_GRUPO_PROD',
    'LNK_PROD_SUBGRUPO_PROD', 'LNK_PROD_SUBST', 'LNK_PROD_VIA_ADMIN', 'LNK_EMB_CNPEM',
    'LNK_COND_ARMAZ_CONSERV'    
]

def copy_table(table, access_cursor, sql_cursor):
    try:
        access_cursor.execute(f"SELECT * FROM [{table}]")
        columns = [desc[0] for desc in access_cursor.description]
        rows = access_cursor.fetchall()
        if not rows:
            print(f"✓ {table}: sem dados")
            return

        placeholders = ', '.join(['?'] * len(columns))
        col_names = ', '.join(f"[{col}]" for col in columns)
        insert = f"INSERT INTO [{table}] ({col_names}) VALUES ({placeholders})"

        for row in rows:
            try:
                sql_cursor.execute(insert, row)
            except Exception as e:
                print(f"  Skipped row in {table}: {e}")
        print(f"✓ {table}: {len(rows)} linhas importadas")
    except Exception as e:
        print(f"❌ {table}: erro ao importar: {e}")

def main():
    access_conn = pyodbc.connect(
        f"DRIVER={{Microsoft Access Driver (*.mdb, *.accdb)}};DBQ={access_path};"
    )
    sql_conn = pyodbc.connect(sql_conn_str)
    access_cursor = access_conn.cursor()
    sql_cursor = sql_conn.cursor()

    for table in import_order:
        copy_table(table, access_cursor, sql_cursor)
        sql_conn.commit()

    access_conn.close()
    sql_conn.close()
    print("\n✅ Importação completa.")

if __name__ == "__main__":
    main()
