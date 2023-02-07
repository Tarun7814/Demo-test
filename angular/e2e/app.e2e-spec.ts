import { tarun_testTemplatePage } from './app.po';

describe('tarun_test App', function() {
  let page: tarun_testTemplatePage;

  beforeEach(() => {
    page = new tarun_testTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
