import { ChangeDetectionStrategy, Component, DestroyRef, effect, inject } from '@angular/core';
import { DomSanitizer, SafeResourceUrl } from '@angular/platform-browser';
import { TranslocoPipe, TranslocoService } from '@jsverse/transloco';

import { NavbarComponent } from '../../components/navbar/navbar.component';
import { LocaleService } from '../../i18n/locale.service';
import { SeoService } from '../../i18n/seo.service';

@Component({
  selector: 'app-contacts',
  imports: [NavbarComponent, TranslocoPipe],
  changeDetection: ChangeDetectionStrategy.OnPush,
  templateUrl: './contacts.component.html',
  styleUrl: './contacts.component.css',
})
export class ContactsComponent {
  private readonly sanitizer = inject(DomSanitizer);
  private readonly i18n = inject(TranslocoService);
  private readonly locale = inject(LocaleService);
  private readonly seo = inject(SeoService);
  private readonly destroyRef = inject(DestroyRef);

  protected readonly phoneHref = 'tel:+380661345327';
  protected readonly phone2Href = 'tel:+380997343159';
  protected readonly mapHref = 'https://maps.google.com/maps?q=48.2077540,22.6427540';
  protected readonly mapEmbedUrl: SafeResourceUrl = this.sanitizer.bypassSecurityTrustResourceUrl(
    'https://maps.google.com/maps?q=48.2077540,22.6427540&z=16&output=embed',
  );
  protected readonly days = ['mon', 'tue', 'wed', 'thu', 'fri', 'sat', 'sun'] as const;

  constructor() {
    effect(() => {
      this.locale.lang();
      const brand = this.i18n.translate('brand');
      const city = this.i18n.translate('contacts.city');
      this.seo.setAlternates('contacts', `${this.i18n.translate('nav.contacts')} · ${brand}`, {
        description: `${this.i18n.translate('contacts.place')}, ${city}. ${this.i18n.translate('seo.description')}`,
      });
    });
    this.destroyRef.onDestroy(() => this.seo.clear());
  }
}
