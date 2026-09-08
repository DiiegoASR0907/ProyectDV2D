# Inventario de assets — Historia en Pixel

Inventario inicial de las 17 imágenes entregadas en el ZIP del 7 de septiembre de 2026.

> Nota editorial: las imágenes se catalogan por función visual y temática. No se asignan identidades reales a las personas representadas; cuando aparece un alias visible como `GENERAL ROJO`, se conserva como etiqueta creativa.

| ID | Archivo original | Categoría | Personaje / tema | Función en Instagram | Estado |
|---|---|---|---|---|---|
| HP-001 | WhatsApp Image 2026-09-07 at 8.32.45 PM (1).jpeg | Ficha de facción | Personaje histórico ficcionalizado + ejército | Carrusel de presentación de personaje/facción | Plantilla |
| HP-002 | WhatsApp Image 2026-09-07 at 8.32.45 PM (2).jpeg | Ficha de facción | Personaje histórico ficcionalizado + unidades | Plantilla reutilizable: personaje → facción → unidades → habilidades → escenarios | Plantilla |
| HP-003 | WhatsApp Image 2026-09-07 at 8.32.45 PM.jpeg | Roster / selección | Dictators Arena — selección de personajes | Pantalla/portada de serie y carrusel de roster | Concepto |
| HP-004 | WhatsApp Image 2026-09-07 at 8.32.46 PM (1).jpeg | Ficha de facción | Personaje histórico ficcionalizado + tropas + escenarios | Post individual o slide central de carrusel | Asset final |
| HP-005 | WhatsApp Image 2026-09-07 at 8.32.46 PM.jpeg | Ficha de facción | Personaje histórico ficcionalizado + ejército | Variante visual para posts de personaje | Plantilla |
| HP-006 | WhatsApp Image 2026-09-07 at 8.32.47 PM (1).jpeg | Ficha táctica | Personaje + ejército + combate | Carrusel de 5 slides: personaje, stats, ejército, habilidades, contexto | Asset final |
| HP-007 | WhatsApp Image 2026-09-07 at 8.32.47 PM.jpeg | Stats / unidad | Personaje histórico ficcionalizado | Post tipo videojuego: ataque, defensa, economía, diplomacia, propaganda, etc. | Concepto |
| HP-008 | WhatsApp Image 2026-09-07 at 8.32.48 PM (1).jpeg | Conflicto / campaña | Guerra, revolución o conflicto histórico ficcionalizado | Carrusel narrativo de campaña + contexto histórico | Asset final |
| HP-009 | WhatsApp Image 2026-09-07 at 8.32.48 PM (2).jpeg | Mapa / escenarios | Campaña histórica y evolución territorial | Serie “Campaign Map”: ascenso → expansión → conflicto → caída | Asset final |
| HP-010 | WhatsApp Image 2026-09-07 at 8.32.48 PM.jpeg | Biblioteca de assets | Personaje + unidades + localizaciones | Base modular para generar múltiples posts por personaje | Plantilla |
| HP-011 | WhatsApp Image 2026-09-07 at 8.32.49 PM (1).jpeg | Identidad de facción | Personaje + ejército + UI militar | Post de identidad visual / ficha de facción | Asset final |
| HP-012 | WhatsApp Image 2026-09-07 at 8.32.49 PM (2).jpeg | Geografía / mapa | Territorio y escenarios históricos | Carrusel “Historia como mapa” con cambios territoriales | Asset final |
| HP-013 | WhatsApp Image 2026-09-07 at 8.32.49 PM (3).jpeg | Branding | HISTORIA EN PIXEL | Foto de perfil, portada, identidad de marca y mockups | Concepto |
| HP-014 | WhatsApp Image 2026-09-07 at 8.32.49 PM.jpeg | Ficha de personaje | Personaje histórico ficcionalizado | Post individual / ficha jugable | Asset final |
| HP-015 | WhatsApp Image 2026-09-07 at 8.32.50 PM (1).jpeg | Ficha de personaje | `GENERAL ROJO` — alias creativo visible | Post de personaje con identidad editorial + contexto histórico | Asset final |
| HP-016 | WhatsApp Image 2026-09-07 at 8.32.50 PM (2).jpeg | Roster / selección | Dictators Arena — roster ampliado | Portada de franquicia, menú de selección o carrusel índice | Concepto |
| HP-017 | WhatsApp Image 2026-09-07 at 8.32.50 PM.jpeg | Branding | HISTORIA EN PIXEL | Feed, avatar y presentación visual de la cuenta | Concepto |

## Taxonomía

- **Asset final:** pieza suficientemente definida para publicación, con ajustes menores opcionales.
- **Concepto:** dirección visual o mockup que todavía conviene desarrollar antes de publicar.
- **Plantilla:** estructura reutilizable para producir una familia de publicaciones.
- **Descartable:** pieza que no aporta al sistema visual o que se reemplazará.

## Arquitectura editorial propuesta

```text
HISTORIA EN PIXEL
├── Personajes
│   ├── Fichas jugables
│   ├── Stats
│   └── Lore histórico
├── Batallas
│   ├── Conflictos
│   └── Campaign Map
├── Mapas
└── Videojuegos
    ├── Dictators Arena
    └── Historia alternativa
```

`DICTATORS ARENA` se trata como una serie dentro de `HISTORIA EN PIXEL`, no como límite de toda la cuenta.

## Siguiente fase

1. Normalizar nombres de archivo (`HP-001.jpg` … `HP-017.jpg`).
2. Separar originales, derivados y exportaciones.
3. Añadir metadatos editoriales por asset: copy, caption, hashtags, fecha objetivo y estado de revisión.
4. Construir plantillas de carrusel a partir de HP-001/002/005/010.
5. Definir branding definitivo usando HP-013/017.
