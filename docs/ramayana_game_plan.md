# Ramayana Game Plan (Combined Master Brief)

## 1) Role & Objective
- **Team role:** Senior AAA studio, coordinated multi-agent system (Game Director, Narrative Designer, Level Designer, Art Director, Gameplay Engineer, Audio Designer, QA Lead).
- **Objective:** Build a complete, playable, high-end aesthetic game inspired by authentic journeys of Rāma and Hanumān (Vālmīki Rāmāyaṇa).
- **Non-negotiable:** No fantasy distortion, no mythology fusion, no spectacle without consequence. Respect chronology, symbolism, and dharma.

## 2) Core Game Vision (Locked)
- **Genre:** Third-person action-adventure + narrative exploration.
- **Tone:** Serene → heroic → tragic → transcendent.
- **Aesthetic:** Cinematic, painterly, spiritual realism (not cartoonish).
- **Camera:** God-of-War-style close third-person with cinematic cuts.
- **Progression:** Story-locked (no grinding before destiny events).

## 3) Platform & Engine (Locked)
- **Engine:** Unity (URP) — fixed for mobile stability, shader control, battery efficiency.
- **Target platform:** Android (primary). iOS optional after vertical slice passes.
- **Performance budget:** 30–45 FPS stable.

## 4) Perspective & Protagonist (Locked)
- **Perspective:** Semi-stylized realism for mobile performance, timeless aesthetic, emotional readability.
- **Primary start:** Child Rāma (playable prologue) → Adult Rāma.
- **Playable switching:** Only when story demands. No free swapping. Hanumān is earned.

## 5) Playable Characters (Sequential)
- **Act I — Rāma (Primary):** Calm, restrained combat, bow mastery, dharma-based choices, exile/forest protection focus.
- **Act II — Hanumān (Unlock):** Speed, strength, devotion-powered abilities, parkour/leaps/stealth/aerial combat, Lanka infiltration, humility → cosmic power arc.

## 6) Story Structure (Mandatory)
- **Prologue:** Ayodhyā at dawn. Silent playable walk as young Rāma. Minimal UI; flute + veena ambience.
- **Act I — Exile:** Chitrakūṭa/Daṇḍakāraṇya traversal. Protect sages; defeat rākṣasas. Sītā abduction as non-playable cinematic.
- **Act II — Search:** Alliance with Sugrīva; introduce Hanumān; emotional low point.
- **Act III — Lankā (Hanumān Arc):** Solo stealth mission. Burning of Lankā as moral burden, not spectacle. Humility monologue.
- **Act IV — War:** Battlefield scale increases. Rāma returns as destiny-driven warrior. No gore; no glorification of rage.
- **Epilogue:** Return, silence, rain. End on peace, not triumph.

## 7) Gameplay Systems (Core)
- **Combat:** Skill-based, deliberate, stamina-driven. Enemies punish button-mashing. Bosses test restraint, not DPS.
- **Dharma System (invisible meter):** Actions affect world tone, NPC reactions, music. No UI numbers; feedback via environment.
- **Exploration:** Sacred spaces reward silence (stand still → world reacts). Overuse of violence dulls color and sound.
- **No fetch quests.** Every mechanic must serve story or dharma.

## 8) Mobile-Specific Design Rules (Non-Negotiable)
- **Camera & controls:** Third-person over-the-shoulder. Virtual joystick (left), context buttons (right). No combo spam. One action = one intention.
- **Level structure:** Semi-open hubs, linear story flow. Hidden loading via forest turns, cave entry, cinematic pauses.
- **Combat (mobile-safe):** Lock-on by proximity. Slow, readable enemy attacks. Dodge > spam attack. Bosses are phased, not crowds.
- **UI:** Minimal, nearly invisible.

## 9) Art Direction (Locked)
- **Global:** Semi-stylized realism; sculptural classical forms; no exaggerated muscles or glowing eyes unless scripturally justified.
- **Palette evolution:**
  - Ayodhyā: gold, white.
  - Forest: green, brown, mist.
  - Lankā: crimson, obsidian.

### Art Mood Sequence (Fixed Order)
1. **Soft Dawn Watercolor — Ayodhyā / Child Rāma**
   - Palette: ivory, gold, pale saffron, sky blue.
   - Lighting: diffused sunrise, long shadows.
   - Textures: watercolor wash, soft edges, minimal contrast.
   - Architecture: smooth, symmetrical, calm geometry.
   - Rule: No sharp edges, no heavy contrast, no dramatic camera moves.
2. **Forest Mist Oil-Paint — Exile / Search**
   - Palette: deep greens, browns, muted blues.
   - Lighting: volumetric fog, filtered sunlight.
   - Texture: visible brush strokes, layered depth.
   - Rule: Violence desaturates world; stillness restores color.
3. **Temple Sculpture Realism — Lankā / War / Epilogue**
   - Palette: stone gray, crimson, obsidian, ash white.
   - Lighting: hard directional light, deep shadows.
   - Rule: No spectacle without consequence. Fire/power feels burdensome.

## 10) Audio Direction
- **Ambient:** Sanskrit shlokas as low-volume layers.
- **Dynamic score:** Reacts to dharma state.
- **Silence:** Intentional after major events.
- **Pairings:**
  - Ayodhyā: light veena, morning birds, distant bells.
  - Forest: wind, insects, low tanpura drone.
  - Lankā/War: low drums, choral hum, long silence gaps.

## 11) Canonical Opening Flow (Confirmed)
1. **Silent playable Child Rāma** — Ayodhyā at dawn; movement + observation only.
2. **Time skip cinematic** — bow ceremony glimpse (non-playable).
3. **Adult Rāma** — exile begins; core mechanics unlock slowly.

## 12) Scene-by-Scene Cinematic Script (Minimal Dialogue)
- **Scene 0 — Ayodhyā at Dawn (Playable):** Child Rāma walks; guard bows; flower falls; Rāma observes. White fade.
- **Scene 1 — The Decree (Cinematic):**
  - Daśaratha: “I gave my word.”
  - Kaikeyī: “Then keep it.”
  - Rāma: “I will go.”
  - No reaction shots; silence afterward.
- **Scene 2 — Exile Departure (Playable → Cinematic):** Walk to gate; crowd parts silently.
  - Lakṣmaṇa: “Where you go, I go.”
  - Rāma nods.
- **Scene 3 — Forest Years (Montage):** Camps, sages protected, seasons change. Wind + tanpura.
- **Scene 4 — Sītā Abduction (Cinematic):** Rāma returns; silence; absence; kneels, touches ground; no tears.
- **Scene 5 — Meeting Hanumān (Interactive):**
  - Hanumān: “I am a servant. Speak, and I will act.”
  - Rāma: “Stand. Walk with me.”
- **Scene 6 — Lankā Infiltration (Playable):** Stealth; sees Sītā; closes eyes; regains control.
- **Scene 7 — Burning of Lankā (Playable):** Fire spreads slowly.
  - Hanumān (inner voice): “This is not victory.”
- **Scene 8 — War (Cinematic + Gameplay):** Minimal shouting. Rāma releases final arrow; doesn’t watch it land.
- **Scene 9 — Return (Cinematic):** Rain, mud, silence; fade before coronation.

## 13) Technical Requirements
- **Modular level design.**
- **Save points:** Only at narrative rests.
- **Input:** Controller + keyboard support (mobile mappings required).
- **Subtitles:** Mandatory.

## 14) Unity Project Structure + Script Skeletons (Planned)
### Folder Structure
```
Assets/
 ├── Art/
 │    ├── Characters/
 │    ├── Environments/
 │    ├── UI/
 │    └── VFX/
 ├── Audio/
 │    ├── Music/
 │    ├── Ambient/
 │    └── VO/
 ├── Scenes/
 │    ├── Prologue/
 │    ├── Forest/
 │    ├── Lanka/
 │    └── War/
 ├── Scripts/
 │    ├── Core/
 │    ├── Characters/
 │    ├── Combat/
 │    ├── Dharma/
 │    └── Cinematics/
 └── Shaders/
```

### Script Skeletons
```csharp
public abstract class PlayerController : MonoBehaviour
{
    protected float stamina;
    public abstract void Move(Vector2 input);
    public abstract void Act();
}

public class RamaController : PlayerController
{
    public override void Act()
    {
        // Bow aim or defend
    }
}

public class HanumanController : PlayerController
{
    public override void Act()
    {
        // Leap, climb, stealth
    }
}

public class DharmaSystem : MonoBehaviour
{
    private float dharmaState;

    public void RegisterAction(bool restrained)
    {
        dharmaState += restrained ? 1f : -1f;
        UpdateWorld();
    }

    void UpdateWorld()
    {
        // Color grading, audio layers, NPC reactions
    }
}

public class CinematicTrigger : MonoBehaviour
{
    public void PlayCinematic(string id)
    {
        // Lock control
        // Play timeline
    }
}
```

## 15) AI Art Prompts (Use One Per Asset)
- **Ayodhyā environment:**
  - “Semi-stylized ancient Indian city at dawn, soft watercolor lighting, ivory and gold palette, calm symmetrical architecture, minimal detail, spiritual realism, painterly textures, mobile-optimized, no fantasy exaggeration.”
- **Forest environment:**
  - “Dense Indian forest with morning mist, oil-paint texture style, layered depth, volumetric fog, muted greens and browns, sacred atmosphere, grounded realism, no saturation, cinematic lighting.”
- **Lankā environment:**
  - “Ancient fortified city carved like temple sculpture, obsidian stone, crimson accents, heavy shadows, dramatic but restrained lighting, moral weight atmosphere, realistic proportions, no fantasy glow.”
- **Rāma character:**
  - “Calm warrior prince, restrained posture, simple dhoti and bow, classical Indian sculpture proportions, serene expression, semi-stylized realism, no exaggerated muscles, no glowing effects.”
- **Hanumān character:**
  - “Humble devoted warrior, athletic but controlled build, expressive eyes, traditional ornaments minimal, movement-ready design, semi-stylized realism, grounded and respectful depiction.”

## 16) Development Sequence (Do Not Skip)
1. **Phase 1 — Vertical Slice (Mandatory):**
   - Playable prologue (Ayodhyā walk).
   - One forest combat.
   - One cinematic.
   - If this fails, project stops.
2. **Phase 2 — Act I (Rāma):** Exile, forest hubs, Dharma system implemented.
3. **Phase 3 — Act II–III (Hanumān):** Movement-heavy gameplay, Lankā stealth mission.
4. **Phase 4 — War + Epilogue:** Scaled battle, controlled spectacle, silent ending.

## 17) Required Outputs (From Agents)
1. Full game design document.
2. Chapter-wise level breakdown.
3. Combat system spec.
4. Art bible.
5. Audio plan.
6. Playable vertical slice (Prologue).

---

## Final Rule (Do Not Break)
If something looks flashy, heroic for spectacle, or loud without meaning — **delete it**.
